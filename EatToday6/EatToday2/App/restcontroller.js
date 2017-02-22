app.controller('restcontroller', function ($scope, restaurantservice) {

    var vm = this;

    $scope.message = "howdy";

    vm.rests = [];

    getrest();

        function getrest() {
            restaurantservice.getrest()
                .then(function (result) {
                   vm.rests = result.data;
                    console.log($scope.rests);
                }, function (error) {
                    $scope.status = 'Unable to load customer data: ' + error.message;
                });
        }
    });


