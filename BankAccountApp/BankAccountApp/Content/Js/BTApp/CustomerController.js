console.log("Hit Customer Controller");
if (typeof BT === 'undefined') { BT = {}; }
BT.App.controller('CustomerController', function ($scope, $http) {
    $scope.clearCustomerInput = function () {
        $scope.form = null;
        $(".cust-group input").val("");
        $(".addr-group input").val("");
        console.log("clear input");
    };
    
    $scope.AddCustomer= function () {
        var _data = {
            FirstName:$scope.fname,
            LastName:$scope.lname,
            CompanyName:$scope.cname,
            Street:$scope.street,
            City:$scope.city,
            State:$scope.state,
            Zip:$scope.zip
        };
        $http({
            method: 'POST',
            url: 'Home/AddCustomer',
            data: _data,
            headers: {
            'Content-type': 'application/json'
        }

        }).then(function (ret) { alert("  ... FInaly ..."); });
        console.log("cust add ... " + $scope.fname);
    };      
});