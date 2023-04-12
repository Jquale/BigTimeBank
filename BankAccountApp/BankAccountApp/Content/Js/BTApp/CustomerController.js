if (typeof BT === 'undefined') { BT = {}; }
BT.App.controller('CustomerController', function ($scope, $http) {
    $scope.clearCustomerInput = function () {
        $scope.form = null;
        $(".cust-group input").val("");
        $(".addr-group input").val("");
    };

    $scope.CustomerLookup = function (term) {
        $http({
            method: "GET",
            url: 'Home/LookupCustomer',
            data: {term}
        }).then(function () {alert("dunzoi"); }); 
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

        }).then(function (ret) { });
    };      
    $scope.LoadCustList = function () {
        $http.Get("Page.CustomerList").then(function (page) {
            $("#partial-load").HTML(page);
        })
    }
});