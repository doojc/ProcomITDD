(function () {
    "use strict";
    angular
        .module("ITDD")
        .controller("ProjectListCtrl",
                     ["projectService",
                         ProjectListCtrl]);

    function ProjectListCtrl(projectService) {
        var vm = this;

        vm.getProjectList = function () {
            projectService.query(function (data) {
                vm.projects = data;
            });
        }
    }
}());
