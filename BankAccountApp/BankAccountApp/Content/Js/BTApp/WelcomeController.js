BT.App.controller('WelcomeController', function ($scope) {
    console.log("Hit WelcomeController");

    $scope.vals = [];
    var theapp = angular.module("MainApp", []);
    theapp.controller('TheController', function ($scope) {
        $scope.submit = function () {
            if ($scope.text) {
                //save to db

                //debugging
                $scope.vals.push($scope.fname);
                $scope.text = '';
            }
        }


    })

});