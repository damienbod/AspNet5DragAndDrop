(function () {
    var mainApp = angular.module("myapp", ["ui.router", "dndLists"]);

    mainApp.config(["$stateProvider", "$urlRouterProvider",
		function ($stateProvider, $urlRouterProvider) {
		    $urlRouterProvider.otherwise("/home");

		    $stateProvider
                .state("home", {
                    url: "/home",
                    templateUrl: "/templates/home.html",
                    controller: "homeController",
                    resolve: {

                        WorkflowService: "WorkflowService",

                        workflows: ["WorkflowService", function (WorkflowService) {
                            return WorkflowService.getWorkflows();
                        }]
                    }
                })
                 
		}
    ]
    );


})();
