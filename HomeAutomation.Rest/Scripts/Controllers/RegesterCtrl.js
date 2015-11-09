var myApp = angular.module('SecurityApp', ['ngAnimate', 'ui.bootstrap']);

myApp.controller('RegisterController', ['$scope', function ($scope) {
    $scope.Email;
    $scope.Password;
    $scope.ConfirmPassword;
    $scope.alerts = [];

    $scope.Register = function () {
        var data = {
            Email: $scope.Email,
            Password: $scope.Password,
            ConfirmPassword: $scope.ConfirmPassword
        };

        ValidatePassword();
        //var valid;
        //if ($scope.Password != $scope.ConfirmPassword) {
        //    valid = 'True';
        //    $scope.alerts.push({ type: "Warning", msg: 'Passwords do not match' });
        //}

        //$.ajax({
        //    type: 'POST',
        //    url: '/api/Account/Register',
        //    contentType: 'application/json; charset=utf-8',
        //    data: JSON.stringify(data)
        //}).done(function (data) {
        //    self.result("Done!");
        //}).fail(showError);
    };

    function ValidatePassword() {
        var valid = 'true';
        var regularExpression = /^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{6,16}$/;
        var minNumberofChars = 6;
        var maxNumberofChars = 16;

        if ($scope.Password < minNumberofChars || $scope.Password > maxNumberofChars) {
            $scope.alerts.push({ type: "warning", msg: 'Passwords must be more than 6 charecters but less than 16' });
            valid = false;
        }

        if ($scope.Password != $scope.ConfirmPassword) {
            valid = 'false';
            $scope.alerts.push({ type: "warning", msg: 'Passwords do not match' });
        }

        if (!regularExpression.test($scope.Password)) {
            $scope.alerts.push({ type: "warning", msg: 'Password should contain at least one number and one special character' });
            valid = 'false';
        }

        return valid;
    }
}]);