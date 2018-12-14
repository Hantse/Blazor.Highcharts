declare var Highcharts;
const highCharts =
{
    init: (chartModel) => Highcharts.chart('chartContainerHighCharts', chartModel)
};
window['highCharts'] = highCharts;
