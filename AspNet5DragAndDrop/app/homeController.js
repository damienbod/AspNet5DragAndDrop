(function () {
    'use strict';

    var module = angular.module('myapp');
   
    function homeController($scope, $log, workflows) {
        $log.info("homeController called");
        $scope.message = "home Controller";
        $scope.workflows = workflows;      

        $scope.models = {
            selected: null,
            lists: { "flow": workflows }
        };


        // Model to JSON for demo purpose
        $scope.$watch('models', function (model) {
            $scope.modelAsJson = angular.toJson(model, true);
        }, true);

    }

    module.controller('homeController', ['$scope', '$log', 'workflows', homeController]);

})();

	 

