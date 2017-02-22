app.factory('restaurantservice', ['$http', function ($http) {

    var restaurantservice = {};

    restaurantservice.getrest = function () {
        return $http.get('/Home/GetJason');
    };
    return restaurantservice;

}]);

