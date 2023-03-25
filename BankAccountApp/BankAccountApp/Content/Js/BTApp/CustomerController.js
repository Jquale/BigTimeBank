// CustomerController.js

app.service('CustomerService', function () {
alert("hit service!");
    //var url = '/GetAll';
    //this.GetAll = function (apiRoute) {
    //    url = apiRoute;
    //    return $http.get(url);
    //}

})

BT.App.controller('CustomerController', ['$scope', 'CustomerService', function ($scope) {
    var baseUrl = 'Customer'
    $scope.GetCustomers = function () {
        var apiRouter = baseUrl + 'GetCUstomers';
        var _customer = CustomerService.GetAll(apiRoute);
        _customer.then(function (response) {
            $scope.customer = response.data;
        })
    }
    $scope.GetCustomers();
}]);


