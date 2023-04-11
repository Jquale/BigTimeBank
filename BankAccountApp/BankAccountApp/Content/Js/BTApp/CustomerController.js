console.log("Hit Customer Controller");
if (typeof BT === 'undefined') { BT = {}; }
BT.App.controller('CustomerController', function ($scope, $http) {
    $scope.clearCustomerInput = function () {
        $scope.form = null;
        console.log("clear input");
    };
    $scope.AddCustomer = function () {
        $http({
            method: 'POST',
            url: 'Home/AddCustomer',
            data: { fName: $scope.fname, lName: $scope.lname, cName: $scope.cname },
            headers: {
            'Content-type': 'application/json'
        }

        }).then(function (ret) { alert(ret); });
        console.log("cust add ... " + $scope.fname);
    };      
});