angular.module('settings', []);

(function() {
    var AppSettingsModule = angular.module('settings');

    // spring backend for local (eclipse tomcat)
    var baseUrl = 'http://' + location.hostname + ':85/';

    AppSettingsModule.constant('REST_API_URL', baseUrl + 'api');


    AppSettingsModule.constant('APP_VERSION', '0.0.0.1-Local');
    AppSettingsModule.constant('APP_ENVIRONMENT', 'Local');
    AppSettingsModule.constant('APP_RELEASE', '#{Octopus.Release.Number}"');
})();
