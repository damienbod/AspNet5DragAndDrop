(function () {
    var mainApp = angular.module("myapp", ["ui.router"]);

    mainApp.config(["$stateProvider", "$urlRouterProvider",
		function ($stateProvider, $urlRouterProvider) {
		    $urlRouterProvider.otherwise("/home");

		    $stateProvider
                .state("home", { url: "/home", templateUrl: "/templates/home.html", controller: "homeController" })
                 
		}
    ]
    );


})();
