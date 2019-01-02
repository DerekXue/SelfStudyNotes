<!DOCTYPE HTML>
<html lang="zh-cn" ng-app>
<head>
    <meta charset="UTF-8">
    <title>scope-hierarchies</title>
    <style type="text/css">
        .ng-cloak {
            display: none;
        }
        .ng-scope {
            border: 1px dashed red;
        }
    </style>
	<script src="http://cdn.static.runoob.com/libs/angular.js/1.4.6/angular.min.js"></script> 
</head>
<body class="ng-cloak">
<div ng-controller="MyController">
    经理：{{employee.name}} [{{department}}] <br/>
    报告：
    <ul>
        <li ng-repeat="employee in employee.reports">
            {{employee.name}} [{{department}}]
        </li>
    </ul>
    <hr/>
    {{greeting}}
</div>
<script src="../angular-1.0.1.js" type="text/javascript"></script>
<script type="text/javascript">
    function MyController($scope) {
        $scope.department = "某部";
        $scope.employee = {
            name:"My Little Dada",
            reports: [
                {name:"Lcllao"},
                {name:"那个谁^o^"}
            ]
        };
    }
</script>
</body>
</html>