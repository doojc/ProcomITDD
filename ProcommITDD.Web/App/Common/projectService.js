(function () {
    "use strict";

    angular
        .module("common.services")
        .factory("projectService", ["$resource", "appSettings", projectService]);

    function projectService($resource, appSettings) {
        return {
            getProjectsList: $resource('/api/project')
        }
    }
}());

