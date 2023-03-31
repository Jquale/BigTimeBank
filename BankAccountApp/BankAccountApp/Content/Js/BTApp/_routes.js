if (typeof BT === 'undefined') { BT = {}; }
BT.App.config(['$routeProvider', function ($route) {
	$route
		.when('/welcome', {
			templateUrl: '/home/page/Welcome'
		})
		.when('/test', {
			templateUrl: '/home/page/Test'
		})
		.when('/customer', {
			templateUrl: 'home/page/Customer/'
		})
		.otherwise({ redirectTo: '/welcome' });
}]);