
$('document').ready(function(){
    var pieCharData = null;
    $.ajax({
        type: 'POST',
        url: '/Home/SeriesData',
        data: {},
        dataType: 'Json',
        success: function(response)
        {
           
            //var seriesData = _.map(response, _.property('name'));
            //    response.map(d => d.value);
            console.log(response);
            pieCharData = response;
            //console.log(dataLabel);
            //console.log(seriesData);

          

            var startObj = response,
                endObj = [], // This could also be {} if you want but if you just have an array in startObj, it doesn't make much sense
                i = 0,
                i_max = startObj.length;
            console.log(i_max);
            for (i; i < i_max; i++) {
                endObj.push(startObj[i].name);
            }
            console.log(endObj);


            var ctx = $('#myChart');
            
            var myChart = new Chart(ctx, JSON.parse(pieCharData));
            
            //var dataLabels = [];
            //var seriesData = [];
            //$(response).each(function () {
            //    dataLabels.push(obj['name']);
            //    seriesData.push(parseInt(obj['value']));
            //});

            //console.log(dataLabels);
            //console.log(seriesData);
        }
    }
)
   
});





































//var sdata = [20.65,50.5,30.80];
//console.log(sdata);
//Highcharts.chart('container', {
//    chart: {
//        plotBackgroundColor: null,
//        plotBorderWidth: null,
//        plotShadow: false,
//        type: 'pie'
//    },
//    title: {
//        text: 'Browser market shares in January, 2018'
//    },
//    tooltip: {
//        pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
//    },
//    accessibility: {
//        point: {
//            valueSuffix: '%'
//        }
//    },
//    plotOptions: {
//        pie: {
//            allowPointSelect: true,
//            cursor: 'pointer',
//            dataLabels: {
//                enabled: true,
//                format: '<b>{point.name}</b>: {point.percentage:.1f} %'
//            }
//        }
//    },

    
//    series: [{
//        name: 'Brands',
//        colorByPoint: true,

//        data: [{
//            name: 'a',
//            y: sdata[0]
//        },
//            {
//                name: 'd',
//                y: sdata[1]
//            },
//            {
//                name: 'p',
//                y: sdata[2]
//            }
//        ]


//        //data: [{
//        //    name: 'internet explorer',
//        //    y: 11.84
//        //}, {
//        //    name: 'firefox',
//        //    y: 10.85
//        //}, {
//        //    name: 'edge',
//        //    y: 4.67
//        //}, {
//        //    name: 'safari',
//        //    y: 4.18
//        //}, {
//        //    name: 'sogou explorer',
//        //    y: 1.64
//        //}, {
//        //    name: 'opera',
//        //    y: 1.6
//        //}, {
//        //    name: 'qq',
//        //    y: 1.2
//        //}, {
//        //    name: 'other',
//        //    y: 2.61
//        //}]

//    }]
//});

////function myFunction(currentValue)
////{
////    { name: 'currentValue',  y = currentValue.a }
////}