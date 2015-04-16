# ToDo-sample
This is a sample application template to show how different languages and build runners can be combinated to build an unified and streamlined buld/deploy-chain

## Technical
This template is based on the todomvc.com sample for angularjs. Therefore, the following technologies came in place for the application itself

* AngularJS
* ASP.NET WebAPI (SelfHosted)

##
What do you need to build?
* NodeJs
* gulp in global (npm install gulp-cli -g)
* bower in global (npm install bower -g)
* git (available in PATH)
* .NET SDK 4.5.1 (Windows 8.1 SDK, http://msdn.microsoft.com/en-us/windows/desktop/bg162891.aspx)
* Microsoft Build Tools 2013 (http://go.microsoft.com/?linkid=9832060, from http://www.visualstudio.com/en-us/downloads)
* NuGet.exe for Packageing (place it in PATH) from http://nuget.org/nuget.exe

##
Alternative: Build with Gradle
* Requirements: Java
* `gradlew ToDoSample.WebApp:gulp_inject` builds the web app (npm install, npm install bower (not incremental), bower install, gulp inject)
* `gradlew ToDoSample.WebApi:msbuild` builds the web api (triggers msbuild) - does not work due to package restore problem
* Pros: same build on build machine and on server, no additional installation other than Java, easy changing of build tool version (i.e. node)
* Cons: abstraction over an abstraction (if you decide to go with gradle, do not have another underlying build tool like gulp, implement this logic in gradle)
* ERROR: I can no longer open the solution in Visual Studio

## Useful Links
* Baby steps with gulp.js: http://jairtrejo.mx/blog/2014/11/baby-steps-with-gulp
* A Beginners Guide to Package Manager Bower and Using Gulp to Manage Components Beginneers http://andy-carter.com/blog/a-beginners-guide-to-package-manager-bower-and-using-gulp-to-manage-components
* gulp-inject: https://www.npmjs.com/package/gulp-inject
* Set Working Directory in gulpfile: http://stackoverflow.com/questions/27236437/set-working-directory-in-gulpfile-js
* Bower Dependencies sorted by dependency: https://www.npmjs.com/package/gulp-concat-vendor
