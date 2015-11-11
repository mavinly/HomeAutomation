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

        if (ValidatePassword()) {
            $.ajax({
                type: 'POST',
                url: '/api/Account/Register',
                contentType: 'application/json; charset=utf-8',
                data: JSON.stringify(data)
            }).done(function (data) {
                self.result("Done!");
            }).fail(function () {
                $scope.alerts = [];
                $scope.alerts.push({ type: "warning", msg: 'Unable to create user' });
            });
        }
    };

    function ValidatePassword() {
        var valid = true;
        var regularExpression = /^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{6,16}$/;
        var minNumberofChars = 6;
        var maxNumberofChars = 16;

        if ($scope.Password.length < minNumberofChars || $scope.Password.length > maxNumberofChars) {
            PushErrorMessage( 'Passwords must be more than 6 charecters but less than 16');
            valid = false;
        }

        if ($scope.Password !== $scope.ConfirmPassword) {
            valid = false;
            PushErrorMessage('Passwords do not match');
        }

        if (!regularExpression.test($scope.Password)) {
            PushErrorMessage('Password should contain at least one number and one special character');
            valid = false;
        }

        return valid;
    }

    function PushErrorMessage(message)
    {
        $scope.alerts.push({ type: "warning", msg: message});
    }

    var compareTo = function() {
    return {
      require: "ngModel",
      scope: {
        otherModelValue: "=compareTo"
      },
      link: function(scope, element, attributes, ngModel) {

        ngModel.$validators.compareTo = function(modelValue) {
          return modelValue == scope.otherModelValue;
        };

        scope.$watch("otherModelValue", function() {
          ngModel.$validate();
        });
      }
    };
  };

  app.directive("compareTo", compareTo);
}]);