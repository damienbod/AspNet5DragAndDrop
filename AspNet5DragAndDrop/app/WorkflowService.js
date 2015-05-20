(function () {
	'use strict';

	function WorkflowService($http, $log) {

		$log.info("WorkflowService called");

		var getWorkflows = function () {
		    $log.info("WorkflowService getWorkflows called");
		    return $http.get("/api/Workflow")
			.then(function (response) {
				return response.data;
			});
		}

		var getSection = function (sectionId) {
		    $log.info("WorkflowService getAnimal called: " + sectionId);
		    $log.info(sectionId);
			return $http.get("/api/Workflow/" + sectionId.sectionId)
			.then(function (response) {
				return response.data;
			});
		}

		return {
		    getWorkflows: getWorkflows,
		    getSection: getSection
		}
	}

	var module = angular.module('myapp');

	module.factory("WorkflowService",
		[
			"$http",
			"$log",
			WorkflowService
		]
	);

})();
