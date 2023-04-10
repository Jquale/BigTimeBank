console.log("Hit Customer Controller");
if (typeof BT === 'undefined') { BT = {}; }
BT.App.controller('CustomerController', function ($scope) {
    $scope.clearCustomerInput = function () {
        $scope.form = null;
        console.log("clar i[nput");
    };
    $scope.AddCustomer = function () {
        console.log("cust add ... " + $scope.form.fname);
    };      
});