var AppName = "TestApp";

(function (appName) {

    var app = angular.module(appName, ["ui.router"]);

    app.config(RouteConfig); 
    RouteConfig.$inject = ["$stateProvider", "$urlRouterProvider"]; 
    function RouteConfig($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise("/");
        $stateProvider
            .state("home", {
                url: "", 
                templateUrl: "/scripts/templates/MainPage.html",
                controller: "edit",
                controllerAs: "edit"
            })
            
    }
}) (AppName);