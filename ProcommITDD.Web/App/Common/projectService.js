(function () {
    "use strict";

    angular
        .module("common.services")
        .factory("projectService",
                ["$resource",
                 "appSettings",                 
                    projectService])

    function projectService($resource, appSettings) {
        return $resource(appSettings.serverPath + "/api/project/:id");
    }
}());

