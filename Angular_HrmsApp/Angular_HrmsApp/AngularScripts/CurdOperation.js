//var app = angular.module("Homeapp", []);
//app.controller("CURDController", function ($scope, $http) {
//    $scope.btntext = "Save";
//    $scope.Savedata = function () {
//        $scope.btntext = "Please Wait...";
//        $http({
//            method: 'POST',
//            url: '/CURD/Add_Record',
//            data: $scope.EmployeeDetails
//        }).then(function (d) {
//            $scope.btntext = "Save";
            
//            $scope.EmployeeDetails = "";
//            alert(d);
//        }).then(function (error) {
//            alert(error);
//        })
//    }
//    //$http.get("/CURD/Get_Record").then(function (d) {
//    //    $scope.EmployeeDetails = d.data;
//    //}, function (error) {
//    //    alert('failed');
//    //})
//    $http({
//        method: 'GET',
//        url: '/CURD/Get_Record',
//    }).then(function (d) {
//        $scope.EmployeeDetails = d.data;;
//    }, function (error) {
//        alert(error);
//    });

//    $scope.loadrecord = function (id) {
//        $http({
//            method: 'GET',
//            url: '/CURD/Get_Data_By_ID?id=' + id,
//        }).then(function (d) {
//            $scope.EmployeeDetails = d.data[0];
//        }, function (error) {
//            alert(error);
//        });
//    }

//    $scope.Updatedata = function () {
//        $scope.btntext = "Please Wait...";
//        $http({
//            method: 'POST',
//            url: '/CURD/Update_Record',
//            data: $scope.EmployeeDetails
//        }).then(function (d) {
//            $scope.btntext = "Update";
//            $scope.EmployeeDetails = "";
//            alert(d);
//        }).then(function (error) {
//            alert(error);
//        })
//    }

//    $scope.delete = function (id) {
//        $http({
//            method: 'GET',
//            url: '/CURD/Delete?id=' + id,
//        }).then(function (d) {
//            alert(d.data);

//        }, function (error) {
//            alert(error);
//        });
//    }
//})

