// MenuebarController.js
BT.App.controller('MenubarController', function ($scope) {
        var baseUrl = 'Menubar';
}
});

function menu($scope) {
    $scope.menuHTML = "<div><input type=button value='BUTTON'> /</div>"
    $("#main-menubar").html($sq.menuHTML);
    angular.bootstrap($('#main-menubar'), ['mainApp']);
}
//BT.App.controller('CustomerController', ['$scope', 'CustomerService', function ($scope) {
//    var baseUrl = 'Customer'
//    $scope.GetCustomers = function () {
//        var apiRouter = baseUrl + 'GetCUstomers';
//        var _customer = CustomerService.GetAll(apiRoute);
//        _customer.then(function (response) {
//            $scope.customer = response.data;
//        })
//    }
//    $scope.GetCustomers();
//}]);

