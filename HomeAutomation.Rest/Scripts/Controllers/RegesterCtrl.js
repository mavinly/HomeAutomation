var myApp = angular.module('SecurityApp', []);

myApp.controller('RegisterController', ['$scope', function ($scope) {
    $scope.Email;
    $scope.Password;
    $scope.ConfirmPassword;

    $scope.Register = function () {
        var test = $scope.Email;
        window.alert(test);
    };
}]);