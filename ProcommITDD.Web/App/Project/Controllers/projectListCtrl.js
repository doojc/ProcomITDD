(function () {
    "use strict";
    angular
        .module("ITDD")
        .controller("ProjectListCtrl", ["projectService", ProjectListCtrl]);

    function ProjectListCtrl(projectService) {
        var vm = this;

        vm.message = "No data found";
        vm.projects = '';

        projectService.getProjectsList.query(
            function(data) {
                vm.projects = data;
            });
        
    }
}());
