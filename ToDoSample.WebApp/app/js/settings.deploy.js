angular.module('settings', []);

(function() {
    var AppSettingsModule = angular.module('settings');

    // spring backend for local (eclipse tomcat)
    var baseUrl = 'http://' + location.hostname + ':89/';

    AppSettingsModule.constant('REST_API_URL', baseUrl + 'api');

    AppSettingsModule.constant('APP_ENVIRONMENT', '#(Octopus.Environment.Name)');
    AppSettingsModule.constant('APP_RELEASE', '#{Octopus.Release.Number}');
})();
