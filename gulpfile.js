var gulp = require('gulp');

var gutil = require('gulp-util');
var debug = require('gulp-debug');

gulp.task('inject', function() {
	
	var inject = require('gulp-inject');	 
	var es = require('event-stream');
	
	var bowerFiles = require('main-bower-files');
	
	var bowerJsCssFiles = bowerFiles();
	var appCssFiles = gulp.src('./app/**/*.css');
	var appJsFiles = gulp.src('./app/**/*.js', { read: false});
	
	gulp.src('index.html', { cwd: 'app'})
	  
	  .pipe(inject(gulp.src(bowerJsCssFiles, {read: false}), {name: 'bower', relative : true}))
	  
	  .pipe(inject(es.merge(appCssFiles, appJsFiles), { relative: true }))
	  
	  .pipe(gulp.dest('./app'));	
	
});

gulp.task('default', ['inject']);