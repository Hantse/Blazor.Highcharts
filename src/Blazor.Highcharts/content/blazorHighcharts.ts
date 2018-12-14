declare var Highcharts;
const highCharts =
{
    init: (chartModel: any) => Highcharts.chart('chartContainerHighCharts', chartModel)
};
window['highCharts'] = highCharts;
