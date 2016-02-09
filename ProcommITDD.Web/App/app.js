(function () {
    "use strict";

    angular.module("ITDD", ['ngRoute','common.services'])
        .config(function ($routeProvider, $locationProvider) {

            $routeProvider.
                when("/", {
                    controller: "ProjectListCtrl",
                    controllerAs: "vm",
                    templateUrl: "/App/Common/Views/Index.html"
                }).
                when("/Project", {
                    controller: "ProjectListCtrl",
                    controllerAs: "vm",
                    templateUrl: "/App/Project/Views/projectListView.html"
                    //resolve: {
                    //    projects: function (projectService) {
                    //        return projectService.getProjectsList.query(function (data) {
                    //            return data;
                    //        });
                    //    }
                    //}
                }).                
                otherwise({
                    redirectTo: "/"
                });

            $locationProvider.html5Mode({
                enabled: true,
                requireBase: false
            });
        });
}());