function GetLineChart() {
    $.ajax({
        url: "/QAManager/GetLineChartData",
        method: "GET",
        success: function (res) {
            var data = JSON.parse(res)
            CreateLineChart(data)
        },
        error: function (err) {
            console.log(err)
        }
    })
}

function CreateLineChart(inputData) {
    var dataset = []
    var colors = ["#3e95cd", "#1dc447", "#d42441", "#9f24d4", "#eded1c"]
    for (var i = 0; i < inputData.length; i++) {
        var data = {
            label: inputData[i].Department,
            data: inputData[i].Total,
            lineTension: 0,
            fill: false,
            /*borderColor: "#" + Math.floor(Math.random() * 16777215).toString(16)*/
            borderColor: colors[i]
        }
        dataset.push(data)
    };
    var chartOptions = {
        legend: {
            display: true,
            position: 'top',
            labels: {
                boxWidth: 80,
                fontColor: 'black'
            }
        }
    };

    var timeData = {
        labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"],
        datasets: dataset
    };

    var lineChart = new Chart(document.getElementById("line-chart"), {
        type: 'line',
        data: timeData,
        options: chartOptions
    });
}

function GetPieChart() {
    $.ajax({
        url: "/QAManager/GetPieChartData",
        method: "GET",
        success: function (res) {
            var data = JSON.parse(res)
            CreatePieChart(data)
        },
        error: function (err) {
            console.log(err)
        }
    })
}

function CreatePieChart(inputData) {
    let departments = [];
    let contributorPercent = [];
    for (var i = 0; i < inputData.length; i++) {
        departments.push(inputData[i].Department)
        contributorPercent.push(inputData[i].Contributors)
    }

    const data = {
        labels: departments,
        datasets: [{
            label: "Contributors(%)",
            data: contributorPercent,
            backgroundColor: ["#3e95cd", "#1dc447", "#d42441", "#9f24d4", "#eded1c"]
        }]
    }

    const config = {
        type: 'pie',
        data: data,
        option: {
            plugins: {
                legend: {
                    display: false
                },
                title: {
                    display: true,
                    text: 'Percent Of Contributor Per DepartMent'
                }
            }
        }
    }

    const chart = new Chart($("#pie-chart"), config)
}

function GetBarChart() {
    $.ajax({
        url: "/QAManager/GetBarChartData",
        method: "GET",
        success: function (res) {
            var data = JSON.parse(res)
            CreateBarChart(data)
        },
        error: function (err) {
            console.log(err)
        }
    })
}

function CreateBarChart(inputData) {

    let categories = [];
    let uses = [];
    for (var i = 0; i < inputData.length; i++) {
        categories.push(inputData[i].Category)
        uses.push(inputData[i].NumOfUses)
    }
    const chart = new Chart($("#bar-chart"), {
        type: 'bar',
        data: {
            labels: categories,
            datasets: [{
                label: "",
                backgroundColor: ["#3e95cd", "#1dc447", "#d42441", "#9f24d4", "#eded1c"],
                data: uses,
            }],
        },
        options: {
            indexAxis: 'y',
            responsive: true,
            legend: { display: false },
            title: {
                display: true,
                text: 'Predicted world population (millions) in 2050'
            }
        }
    })

}

function GetMixedChart() {
    $.ajax({
        url: "/QAManager/GetMixedChartData",
        method: "GET",
        success: function (res) {
            var data = JSON.parse(res)
            CreateMixedChart(data)
        },
        error: function (err) {
            console.log(err)
        }
    })
}

function CreateMixedChart(inputData) {
    var views = [];
    var points = [];
    var time = [];
    for (var i = 0; i < inputData.length; i++) {
        views.push(inputData[i].View)
        points.push(inputData[i].Point)
        time.push(inputData[i].Date)
    }
    new Chart(document.getElementById("mixed-chart"), {
        type: 'bar',
        data: {
            labels: time,
            datasets: [{
                label: "Point",
                type: "line",
                borderColor: "#8e5ea2",
                data: points,
                fill: false
            }, {
                label: "View",
                type: "line",
                borderColor: "#3e95cd",
                data: views,
                fill: false
            }, {
                label: "Point",
                type: "bar",
                backgroundColor: ["#d4c222"],
                data: points,
            }, {
                label: "View",
                type: "bar",
                backgroundColor: ["#29c254"],
                backgroundColorHover: "#3e95cd",
                data: views
            }
            ]
        },
        options: {
            title: {
                display: true,
                text: 'Total Points and View of Ideas within lastest 7 days'
            },
            legend: { display: true }
        }
    })
}

GetLineChart()
GetPieChart()
GetBarChart()
GetMixedChart()