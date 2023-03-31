BT.App.controller('WelcomeController', function ($scope, $http) {
    console.log("Hit WelcomeController");

    $scope.vals = [];
    $scope.submit = function () {
        var _data = {
            fName: $scope.fname,
            lName: $scope.lname,
            cName: $scope.cname
        };
        //save to db
        saveCustomer: function() {
            return $http({
                url: 'Home/SaveCustomer/',
                method: "POST",
                data: _data,
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            }).success(function (data, status, headers, config) {
                $scope.persons = data; // assign  $scope.persons here as promise is resolved here 
            }).error(function (data, status, headers, config) {
                $scope.status = status;
            });

        alert($scope.fname);
        //debugging
        $scope.vals.push($scope.fname + "," + $scope.lname + "," + $scope.cname);

        $http.post("")
    }
});



