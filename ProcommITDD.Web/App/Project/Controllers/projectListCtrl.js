(function () {
    "use strict";
    angular
        .module("ITDD")
        .controller("ProjectListCtrl", ["projectService", ProjectListCtrl]);

    function ProjectListCtrl(projectService) {
        var vm = this;

        vm.message = "No data found";
        vm.errorMessage = '';
        vm.projects = '';

        projectService.getProjectsList.query(
            function(data) {
                vm.projects = data;
                vm.gridOptions.data;
            },
            function (response) {
                vm.errorMessage = response.statusText + "\r\n";
                if (response.data.Message)
                    vm.errorMessage += response.data.Message;
            });
        
    }
}());
