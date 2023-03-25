'use strict'

    src = "http://ajax.googleapis.com/ajax/libs/angularjs/1.6.9 angular.min.js"
app.service('CustomerService', function () { 

    var url = 'Home/GetAll';
    this.GetAll = function (apiRoute) {
        url = apiRoute;
        return $http.get(url);
    }

})
BT.App.controller('CustomerController', ['$scope', 'CustomerService' function ($scope) {
    var baseUrl = 'Home';
    $scope.GetCustomers = function () {
        var apiRouter = baseUrl + 'GetCUstomers';
        var _customer = CustomerService.GetAll(apiRoute);
        _customer.then(function (response) {
            $scope.customer = response.data;
        })
    }
    $scope.GetCustomers();
}]);

