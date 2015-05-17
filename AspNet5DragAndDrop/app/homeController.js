(function () {
    'use strict';

    var module = angular.module('myapp');
   
    function homeController($scope, $log) {
        $log.info("homeController called");
        $scope.message = "home Controller";

    }

    module.controller('homeController', ['$scope', '$log', homeController]);

})();

	 

