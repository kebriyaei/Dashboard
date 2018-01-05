using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using DotNet.Highcharts;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;

/// <summary>
/// Summary description for Charts
/// </summary>
public class Charts
{
	public Charts()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    
    public static Highcharts GetGaugeDailyWeight(DataTable dt, string CategoryTheme, string ChartName)
    {
        List<Series> seriGauge = ChartSeries.GetGaugeSeriWeight(dt);
        //List<XAxis> xAxisGauge = ChartSeries.GetChartxAxisGauge(dtGauge);
        //List<YAxis> yAxisGauge = ChartSeries.GetChartyAxisGauge(dtGauge);360500
        DotNet.Highcharts.Highcharts ChartGaugeWeight = new DotNet.Highcharts.Highcharts(ChartName)
        .SetCredits(new Credits
            {
                Enabled=false
            })
            .SetExporting(new Exporting
                {
                    Enabled=false
                })
        .InitChart(new Chart
        {
            DefaultSeriesType = ChartTypes.Gauge,
            Events = new ChartEvents
            {
                Load = "function (){setInterval(UpdateChartWeight,360500);}"
            },
            Width = 270,
            Height = 190,
            //BackgroundColor= new BackColorOrGradient(Color.Azure)
        })
        .SetTitle(new Title { Text = "" })
        .SetPane(new Pane
        {
            Center = new List<PercentageOrPixel> { new PercentageOrPixel(120, false), new PercentageOrPixel(120, false) }.ToArray(),
            Size = new PercentageOrPixel(220, false),
            StartAngle = -90,
            EndAngle = 90,
            Background = new List<BackgroundObject>
            {
                new BackgroundObject{
                    BackgroundColor = new BackColorOrGradient(Color.Black),
                    InnerRadius = new PercentageOrPixel(30, true),
                    OuterRadius = new PercentageOrPixel(10, true)
                }

            }.ToArray()
        }
        )
        .SetYAxis(new YAxis
        {
            Min = 0,
            Max = 2700,

            //MinorTickInterval="auto",
            MinorTickWidth = 1,
            MinorTickLength = 10,
            MinorTickPosition = new TickPositions(),
            MinorTickColor = Color.Purple,

            TickPixelInterval = 30,
            TickWidth = 2,
            TickPosition = new TickPositions(),
            TickLength = 10,
            TickColor = Color.Black,


            //Labels=new List<Labels>
            //{
            //  step
            //}.ToArray(),


            //labels: {
            //    step: 2,
            //    rotation: 'auto'
            //},

            //Title= new Title
            //{
            //    Text="فروش/امروز"

            //},

            PlotBands = new List<YAxisPlotBands>
            {
                new YAxisPlotBands{
                From=0,
                To=700,
                Color=Color.Red
                },
                new YAxisPlotBands{
                From=700,
                To=1500,
                Color=Color.Yellow
                },
               new YAxisPlotBands{
                From=1500,
                To=2700,
                Color=Color.Green
                }
            }.ToArray()
        })
    .SetSeries(seriGauge.ToArray());
        return ChartGaugeWeight;
    }
    public static Highcharts GetGaugeDailyRial(DataTable dt, string CategoryTheme, string ChartName)
    {
        List<Series> seriGauge = ChartSeries.GetGaugeSeriRial(dt);
        //List<XAxis> xAxisGauge = ChartSeries.GetChartxAxisGauge(dtGauge);
        //List<YAxis> yAxisGauge = ChartSeries.GetChartyAxisGauge(dtGauge);360500
        DotNet.Highcharts.Highcharts ChartGaugeRial = new DotNet.Highcharts.Highcharts(ChartName)
        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetExporting(new Exporting
        {
            Enabled = false
        })
        .InitChart(new Chart
        {
            DefaultSeriesType = ChartTypes.Gauge,
            Events = new ChartEvents
            {
                Load = "function (){setInterval(UpdateChartRial,360500);}"
            },
            Width = 270,
            Height = 190
        })
        .SetTitle(new Title { Text = "" })
        .SetPane(new Pane
        {
            Center = new List<PercentageOrPixel> { new PercentageOrPixel(120, false), new PercentageOrPixel(120, false) }.ToArray(),
            Size = new PercentageOrPixel(220, false),
            StartAngle = -90,
            EndAngle = 90,
            Background = new List<BackgroundObject>
            {
                new BackgroundObject{
                    BackgroundColor = new BackColorOrGradient(Color.Black),
                    InnerRadius = new PercentageOrPixel(30, true),
                    OuterRadius = new PercentageOrPixel(10, true),
                }

            }.ToArray()
        }
        )
        .SetYAxis(new YAxis
        {
            Min = 0,
            Max = 150000,

            //MinorTickInterval="auto",
            MinorTickWidth = 1,
            MinorTickLength = 10,
            MinorTickPosition = new TickPositions(),
            MinorTickColor = Color.Purple,

            TickPixelInterval = 30,
            TickWidth = 2,
            TickPosition = new TickPositions(),
            TickLength = 10,
            TickColor = Color.Black,


            //Labels=new List<Labels>
            //{
            //  step
            //}.ToArray(),


            //labels: {
            //    step: 2,
            //    rotation: 'auto'
            //},

            //Title= new Title
            //{
            //    Text="فروش/امروز"

            //},

            PlotBands = new List<YAxisPlotBands>
            {
                new YAxisPlotBands{
                From=0,
                To=40000,
                Color=Color.Red
                },
                new YAxisPlotBands{
                From=40000,
                To=80000,
                Color=Color.Yellow
                },
               new YAxisPlotBands{
                From=80000,
                To=150000,
                Color=Color.Green
                }
            }.ToArray()
        })
    .SetSeries(seriGauge.ToArray());
        return ChartGaugeRial;
    }

    public static Highcharts GetChartLine(DataTable dt, string CategoryTheme, string ChartName)
    {
        List<Series> seri = ChartSeries.GetChartSeriLine(dt, CategoryTheme);
        List<XAxis> xAxis = ChartSeries.GetChartxAxis(dt);
        List<YAxis> yAxis = ChartSeries.GetChartyAxis(dt);
        // Declare the HighCharts object   
        DotNet.Highcharts.Highcharts LineChart = new DotNet.Highcharts.Highcharts(ChartName)
        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetExporting(new Exporting
        {
            Enabled = false
        })
        .SetOptions(new GlobalOptions
        {
            Colors = new[]
                                         {
                                             ColorTranslator.FromHtml("#DDDF0D"),
                                             ColorTranslator.FromHtml("#7798BF"),
                                             ColorTranslator.FromHtml("#55BF3B"),
                                             ColorTranslator.FromHtml("#DF5353"),
                                             ColorTranslator.FromHtml("#DDDF0D"),
                                             ColorTranslator.FromHtml("#aaeeee"),
                                             ColorTranslator.FromHtml("#ff0066"),
                                             ColorTranslator.FromHtml("#eeaaee")
                                             

                                         }
        })
        .InitChart(new Chart
        {
            DefaultSeriesType = ChartTypes.Line,
            //Events = new ChartEvents
            //{
            //    Load = "function (){setInterval(UpdateChartRial,360500);}"
            //},
            Height = 250,
            ClassName = "ltrChart"
        })
            .SetTitle(new Title
            {
                Text = "",
                X = 0
            })
            //.SetSubtitle(new Subtitle
            //{
            //    Text = "تست تست تست تست",
            //    X = 0
            //})
            .SetYAxis(yAxis.ToArray())
            .SetXAxis(xAxis.ToArray())
            .SetSeries(seri.ToArray())
            .SetLegend(new Legend
            {

                Align = HorizontalAligns.Center,
                VerticalAlign = VerticalAligns.Bottom,
                Layout = Layouts.Horizontal,
                //LabelFormatter = "function() {return '---' + this.name ;}"

                //BorderWidth=1,
                //Width=380,
                //Floating=true,
                ////X=-35,
                //SymbolRadius=0,
                //SymbolWidth=10,
                //SymbolHeight=10,
                //Enabled=true,
                //ItemStyle = "textAlign: 'right'",
                //ItemMarginBottom=40


            })
            .SetTooltip(new Tooltip {  Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }" })
            ;
        return LineChart;
    }
    public static Highcharts GetChartBar(DataTable dt, string CategoryTheme,string ChartName)
    {

        List<Series> seri = ChartSeries.GetChartSeri(dt, CategoryTheme);
        List<XAxis> xAxis = ChartSeries.GetChartxAxis(dt);
        List<YAxis> yAxis = ChartSeries.GetChartyAxis(dt);
        // Declare the HighCharts object   
        DotNet.Highcharts.Highcharts BarChart = new DotNet.Highcharts.Highcharts(ChartName)
        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetExporting(new Exporting
        {
            Enabled = false
        })
       .SetOptions(new GlobalOptions
       {
           Lang = new DotNet.Highcharts.Helpers.Lang().SetAndUseCulture(""),
           Global = new Global { UseUTC = false }
       })
        .InitChart(new Chart
        {
            //    Events = new ChartEvents
            //            {
            //                Load = "ChartEventsLoad"
            //            },
            DefaultSeriesType = ChartTypes.Column,
            Height = 300,
            ClassName = "ltrChart"
            //BorderWidth = 0,
            //                   BorderRadius = 15,
            //                   PlotBackgroundColor = null,
            //                   PlotShadow = false,
            //                   PlotBorderWidth = 0,
            //                   BackgroundColor = new BackColorOrGradient(new Gradient
            //                                                             {
            //                                                                 LinearGradient = new[] { 0, 0, 0, 400 },
            //                                                                 Stops = new object[,]
            //                                                                         {
            //                                                                             { 0, Color.FromArgb(255, 96, 96, 96) },
            //                                                                             { 1, Color.FromArgb(255, 16, 16, 16) }
            //                                                                         }
            //                                                             })
        })

            .SetTitle(new Title
            {
                Text = "",
                X = 0
            })
            //.SetSubtitle(new Subtitle
            //{
            //    Text = "تست تست تست تست",
            //    X = 0
            //})
            .SetYAxis(yAxis.ToArray())
            .SetXAxis(xAxis.ToArray())
            .SetSeries(seri.ToArray())
            .SetLegend(new Legend
            {

                Align = HorizontalAligns.Center,
                VerticalAlign = VerticalAligns.Bottom,
                Layout = Layouts.Horizontal,
                //LabelFormatter = "function() {return '---' + this.name ;}"

                //BorderWidth=1,
                //Width=380,
                //Floating=true,
                ////X=-35,
                //SymbolRadius=0,
                //SymbolWidth=10,
                //SymbolHeight=10,
                //Enabled=true,
                //ItemStyle = "textAlign: 'right'",
                //ItemMarginBottom=40
                

            })
            .SetTooltip(new Tooltip { 
                //Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }" 
                HeaderFormat = " <span style=\"font-size:10px\">{point.key}</span><table> ",
                PointFormat = " <tr><td style=\"color:{series.color};padding:0\">{series.name}: </td><td style=\"padding:0\"><b>{point.y} </b></td></tr> ",
                FooterFormat = " </table>",
                Shared = true,
                UseHTML = true
            })
            //.SetTooltip(new Tooltip
            //{
            //    Formatter = "function() { return '<div style=\"textAlign: right !important\"><b>'+ this.series.name +'</b><br/>'+this.x +': '+ this.y +'</div>';}",
            //    //Style = "textAlign: 'right !important' ,float: 'right !important'"
            //})
            ;
        return BarChart;
    }
    public static Highcharts GetChartBarKPI(DataTable dt, string CategoryTheme, string ChartName)
    {

        List<Series> seri = ChartSeries.GetChartSeriKPI(dt, CategoryTheme);
        List<XAxis> xAxis = ChartSeries.GetChartxAxisKPI(dt);
        List<YAxis> yAxis = ChartSeries.GetChartyAxisKPI(dt);
        // Declare the HighCharts object   
        DotNet.Highcharts.Highcharts BarChart = new DotNet.Highcharts.Highcharts(ChartName)
        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetExporting(new Exporting
        {
            Enabled = false
        })
       .SetOptions(new GlobalOptions
       {
           Lang = new DotNet.Highcharts.Helpers.Lang().SetAndUseCulture(""),
           Global = new Global { UseUTC = false }
       })
        .InitChart(new Chart
        {
            //    Events = new ChartEvents
            //            {
            //                Load = "ChartEventsLoad"
            //            },
            DefaultSeriesType = ChartTypes.Column,
            Height = 200,
            ClassName = "ltrChart"
            //BorderWidth = 0,
            //                   BorderRadius = 15,
            //                   PlotBackgroundColor = null,
            //                   PlotShadow = false,
            //                   PlotBorderWidth = 0,
            //                   BackgroundColor = new BackColorOrGradient(new Gradient
            //                                                             {
            //                                                                 LinearGradient = new[] { 0, 0, 0, 400 },
            //                                                                 Stops = new object[,]
            //                                                                         {
            //                                                                             { 0, Color.FromArgb(255, 96, 96, 96) },
            //                                                                             { 1, Color.FromArgb(255, 16, 16, 16) }
            //                                                                         }
            //                                                             })
        })

            .SetTitle(new Title
            {
                Text = "",
                X = 0
            })
            //.SetSubtitle(new Subtitle
            //{
            //    Text = "تست تست تست تست",
            //    X = 0
            //})
            .SetYAxis(yAxis.ToArray())
            .SetXAxis(xAxis.ToArray())
            .SetSeries(seri.ToArray())
            .SetLegend(new Legend
            {

                Align = HorizontalAligns.Center,
                VerticalAlign = VerticalAligns.Bottom,
                Layout = Layouts.Horizontal,
                //LabelFormatter = "function() {return '---' + this.name ;}"

                //BorderWidth=1,
                //Width=380,
                //Floating=true,
                ////X=-35,
                //SymbolRadius=0,
                //SymbolWidth=10,
                //SymbolHeight=10,
                //Enabled=true,
                //ItemStyle = "textAlign: 'right'",
                //ItemMarginBottom=40


            })
            .SetTooltip(new Tooltip
            {
                //Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }" 
                HeaderFormat = " <span style=\"font-size:10px\">{point.key}</span><table> ",
                PointFormat = " <tr><td style=\"color:{series.color};padding:0\">{series.name}: </td><td style=\"padding:0\"><b>{point.y} </b></td></tr> ",
                FooterFormat = " </table>",
                Shared = true,
                UseHTML = true
            })
            //.SetTooltip(new Tooltip
            //{
            //    Formatter = "function() { return '<div style=\"textAlign: right !important\"><b>'+ this.series.name +'</b><br/>'+this.x +': '+ this.y +'</div>';}",
            //    //Style = "textAlign: 'right !important' ,float: 'right !important'"
            //})
            ;
        return BarChart;
    }
    public static Highcharts GetChartBarKPI150(DataTable dt, string CategoryTheme, string ChartName)
    {

        List<Series> seri = ChartSeries.GetChartSeriKPI(dt, CategoryTheme);
        List<XAxis> xAxis = ChartSeries.GetChartxAxisKPI(dt);
        List<YAxis> yAxis = ChartSeries.GetChartyAxisKPI(dt);
        // Declare the HighCharts object   
        DotNet.Highcharts.Highcharts BarChart = new DotNet.Highcharts.Highcharts(ChartName)
        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetExporting(new Exporting
        {
            Enabled = false
        })
       .SetOptions(new GlobalOptions
       {
           Lang = new DotNet.Highcharts.Helpers.Lang().SetAndUseCulture(""),
           Global = new Global { UseUTC = false }
       })
        .InitChart(new Chart
        {
            //    Events = new ChartEvents
            //            {
            //                Load = "ChartEventsLoad"
            //            },
            DefaultSeriesType = ChartTypes.Column,
            Height = 150,
            ClassName = "ltrChart"
            //BorderWidth = 0,
            //                   BorderRadius = 15,
            //                   PlotBackgroundColor = null,
            //                   PlotShadow = false,
            //                   PlotBorderWidth = 0,
            //                   BackgroundColor = new BackColorOrGradient(new Gradient
            //                                                             {
            //                                                                 LinearGradient = new[] { 0, 0, 0, 400 },
            //                                                                 Stops = new object[,]
            //                                                                         {
            //                                                                             { 0, Color.FromArgb(255, 96, 96, 96) },
            //                                                                             { 1, Color.FromArgb(255, 16, 16, 16) }
            //                                                                         }
            //                                                             })
        })

            .SetTitle(new Title
            {
                Text = "",
                X = 0
            })
            //.SetSubtitle(new Subtitle
            //{
            //    Text = "تست تست تست تست",
            //    X = 0
            //})
            .SetYAxis(yAxis.ToArray())
            .SetXAxis(xAxis.ToArray())
            .SetSeries(seri.ToArray())
            .SetLegend(new Legend
            {

                Align = HorizontalAligns.Center,
                VerticalAlign = VerticalAligns.Bottom,
                Layout = Layouts.Horizontal,
                //LabelFormatter = "function() {return '---' + this.name ;}"

                //BorderWidth=1,
                //Width=380,
                //Floating=true,
                ////X=-35,
                //SymbolRadius=0,
                //SymbolWidth=10,
                //SymbolHeight=10,
                //Enabled=true,
                //ItemStyle = "textAlign: 'right'",
                //ItemMarginBottom=40


            })
            .SetTooltip(new Tooltip
            {
                //Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }" 
                HeaderFormat = " <span style=\"font-size:10px\">{point.key}</span><table> ",
                PointFormat = " <tr><td style=\"color:{series.color};padding:0\">{series.name}: </td><td style=\"padding:0\"><b>{point.y} </b></td></tr> ",
                FooterFormat = " </table>",
                Shared = true,
                UseHTML = true
            })
            //.SetTooltip(new Tooltip
            //{
            //    Formatter = "function() { return '<div style=\"textAlign: right !important\"><b>'+ this.series.name +'</b><br/>'+this.x +': '+ this.y +'</div>';}",
            //    //Style = "textAlign: 'right !important' ,float: 'right !important'"
            //})
            ;
        return BarChart;
    }
    public static Highcharts GetChartBarGroup(DataTable dt, string CategoryTheme, string ChartName)
    {

        List<Series> seri = ChartSeries.GetChartSeriBarGroup(dt, CategoryTheme);
        List<XAxis> xAxis = ChartSeries.GetChartxAxis(dt);
        List<YAxis> yAxis = ChartSeries.GetChartyAxis(dt);
        // Declare the HighCharts object   
        DotNet.Highcharts.Highcharts BarChart = new DotNet.Highcharts.Highcharts(ChartName)
        
        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetExporting(new Exporting
        {
            Enabled = false
        })
            .SetOptions(new GlobalOptions
            {
                Colors=new Color[]{
                   ColorTranslator.FromHtml("#5b5b5f"),
                    ColorTranslator.FromHtml("#983c10"),
                    ColorTranslator.FromHtml("#6b1470")
                },
                Lang = new DotNet.Highcharts.Helpers.Lang().SetAndUseCulture(""),
                Global = new Global { UseUTC = false }
            })
        .InitChart(new Chart
        {
            //    Events = new ChartEvents
            //            {
            //                Load = "ChartEventsLoad"
            //            },
            DefaultSeriesType = ChartTypes.Column,
            Height = 400,
            ClassName="ltrChart"            
            //BorderWidth = 0,
            //                   BorderRadius = 15,
            //                   PlotBackgroundColor = null,
            //                   PlotShadow = false,
            //                   PlotBorderWidth = 0,
            //                   BackgroundColor = new BackColorOrGradient(new Gradient
            //                                                             {
            //                                                                 LinearGradient = new[] { 0, 0, 0, 400 },
            //                                                                 Stops = new object[,]
            //                                                                         {
            //                                                                             { 0, Color.FromArgb(255, 96, 96, 96) },
            //                                                                             { 1, Color.FromArgb(255, 16, 16, 16) }
            //                                                                         }
            //                                                             })
        }).SetTitle(new Title
            {
                Text = "",
                X = 0
            })
            //.SetSubtitle(new Subtitle
            //{
            //    Text = "تست تست تست تست",
            //    X = 0
            //})

            .SetYAxis(yAxis.ToArray())
            .SetXAxis(xAxis.ToArray())
            .SetSeries(seri.ToArray())
            .SetLegend(new Legend
            {

                Align = HorizontalAligns.Center,
                VerticalAlign = VerticalAligns.Bottom,
                Layout = Layouts.Horizontal,
                 
               // LabelFormatter = "function() {return '---' + this.name ;}"

                //BorderWidth=1,
                //Width=380,
                //Floating=true,
                ////X=-35,
                //SymbolRadius=0,
                //SymbolWidth=10,
                //SymbolHeight=10,
                //Enabled=true,
                //ItemStyle = "textAlign: 'right'",
                //ItemMarginBottom=40


            })
            .SetTooltip(new Tooltip { 
                //Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }" 
                HeaderFormat = " <span style=\"font-size:10px\">{point.key}</span><table> ",
                PointFormat = " <tr><td style=\"color:{point.color};padding:0\">{series.name}: </td><td style=\"padding:0\"><b>{point.y} </b></td></tr> ",
                FooterFormat = " </table>",
                Shared = true,
                UseHTML = true
            })
            ;
        return BarChart;
    }
    public static Highcharts GetChartBarGroupThreeSeries(DataTable dt, string CategoryTheme, string ChartName)
    {

        List<Series> seri = ChartSeries.GetChartSeriBarGroupThreeSeries(dt, CategoryTheme);
        List<XAxis> xAxis = ChartSeries.GetChartxAxisThree(dt);
        List<YAxis> yAxis = ChartSeries.GetChartyAxis(dt);
        // Declare the HighCharts object   
        DotNet.Highcharts.Highcharts BarChart = new DotNet.Highcharts.Highcharts(ChartName)

        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetExporting(new Exporting
        {
            Enabled = false
        })
            .SetOptions(new GlobalOptions
            {
                Colors = new Color[]{
                    ColorTranslator.FromHtml("#5b5b5f"),
                    ColorTranslator.FromHtml("#983c10"),
                    ColorTranslator.FromHtml("#6b1470")
                },
                Lang = new DotNet.Highcharts.Helpers.Lang().SetAndUseCulture(""),
                Global = new Global { UseUTC = false }
            })
        .InitChart(new Chart
        {
            //    Events = new ChartEvents
            //            {
            //                Load = "ChartEventsLoad"
            //            },
            DefaultSeriesType = ChartTypes.Column,
            Height = 400,
            ClassName = "ltrChart"
            //BorderWidth = 0,
            //                   BorderRadius = 15,
            //                   PlotBackgroundColor = null,
            //                   PlotShadow = false,
            //                   PlotBorderWidth = 0,
            //                   BackgroundColor = new BackColorOrGradient(new Gradient
            //                                                             {
            //                                                                 LinearGradient = new[] { 0, 0, 0, 400 },
            //                                                                 Stops = new object[,]
            //                                                                         {
            //                                                                             { 0, Color.FromArgb(255, 96, 96, 96) },
            //                                                                             { 1, Color.FromArgb(255, 16, 16, 16) }
            //                                                                         }
            //                                                             })
        }).SetTitle(new Title
        {
            Text = "",
            X = 0
        })
            //.SetSubtitle(new Subtitle
            //{
            //    Text = "تست تست تست تست",
            //    X = 0
            //})

            .SetYAxis(yAxis.ToArray())
            .SetXAxis(xAxis.ToArray())
            .SetSeries(seri.ToArray())
            .SetLegend(new Legend
            {

                Align = HorizontalAligns.Center,
                VerticalAlign = VerticalAligns.Bottom,
                Layout = Layouts.Horizontal,

                // LabelFormatter = "function() {return '---' + this.name ;}"

                //BorderWidth=1,
                //Width=380,
                //Floating=true,
                ////X=-35,
                //SymbolRadius=0,
                //SymbolWidth=10,
                //SymbolHeight=10,
                //Enabled=true,
                //ItemStyle = "textAlign: 'right'",
                //ItemMarginBottom=40


            })
            .SetTooltip(new Tooltip
            {
                //Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }" 
                HeaderFormat = " <span style=\"font-size:10px\">{point.key}</span><table> ",
                PointFormat = " <tr><td style=\"color:{point.color};padding:0\">{series.name}: </td><td style=\"padding:0\"><b>{point.y} </b></td></tr> ",
                FooterFormat = " </table>",
                Shared = true,
                UseHTML = true
            })
            ;
        return BarChart;
    }
    public static Highcharts GetChartBarBig(DataTable dt, string CategoryTheme, string ChartName)
    {

        List<Series> seri = ChartSeries.GetChartSeri(dt, CategoryTheme);
        List<XAxis> xAxis = ChartSeries.GetChartxAxisBarBig(dt);
        List<YAxis> yAxis = ChartSeries.GetChartyAxis(dt);
        // Declare the HighCharts object   
        DotNet.Highcharts.Highcharts BarChart = new DotNet.Highcharts.Highcharts(ChartName)
        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetExporting(new Exporting
        {
            Enabled = false
        })
            //.SetOptions(new GlobalOptions
            //{
            //    Lang = new DotNet.Highcharts.Helpers.Lang().SetAndUseCulture(""),
            //    Global = new Global { UseUTC = false }
            //})
        .InitChart(new Chart
        {
            //    Events = new ChartEvents
            //            {
            //                Load = "ChartEventsLoad"
            //            },
            DefaultSeriesType = ChartTypes.Column,
            Height = 600,
            ClassName = "ltrChart"
            //BorderWidth = 0,
            //                   BorderRadius = 15,
            //                   PlotBackgroundColor = null,
            //                   PlotShadow = false,
            //                   PlotBorderWidth = 0,
            //                   BackgroundColor = new BackColorOrGradient(new Gradient
            //                                                             {
            //                                                                 LinearGradient = new[] { 0, 0, 0, 400 },
            //                                                                 Stops = new object[,]
            //                                                                         {
            //                                                                             { 0, Color.FromArgb(255, 96, 96, 96) },
            //                                                                             { 1, Color.FromArgb(255, 16, 16, 16) }
            //                                                                         }
            //                                                             })
        })

            .SetTitle(new Title
            {
                Text = "",
                X = 0
            })
            //.SetSubtitle(new Subtitle
            //{
            //    Text = "تست تست تست تست",
            //    X = 0
            //})
            
            .SetXAxis(xAxis.ToArray())
            .SetYAxis(yAxis.ToArray())
            //.SetLegend(new Legend { Enabled = false })
            //.SetPlotOptions(new PlotOptions { Bar = new PlotOptionsBar { BorderWidth = 0 } })
            .SetSeries(seri.ToArray())
            .SetLegend(new Legend
            {

                Align = HorizontalAligns.Center,
                VerticalAlign = VerticalAligns.Bottom,
                Layout = Layouts.Horizontal,
                //LabelFormatter = "function() {return '---' + this.name ;}"

                //BorderWidth=1,
                //Width=380,
                //Floating=true,
                ////X=-35,
                //SymbolRadius=0,
                //SymbolWidth=10,
                //SymbolHeight=10,
                //Enabled=true,
                //ItemStyle = "textAlign: 'right'",
                //ItemMarginBottom=40


            })
            .SetTooltip(new Tooltip {
                //Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }"
                HeaderFormat = " <span style=\"font-size:10px\">{point.key}</span><table> ",
                PointFormat = " <tr><td style=\"color:{series.color};padding:0\">{series.name}: </td><td style=\"padding:0\"><b>{point.y} </b></td></tr> ",
                FooterFormat = " </table>",
                Shared = true,
                UseHTML = true
            })
            ;
        return BarChart;
    }
    //public static Highcharts GetChartBarSupplierDetailsRial(DataTable dt, string CategoryTheme, string ChartName)
    //{

    //    List<Series> seri = ChartSeries.GetChartSeri(dt, CategoryTheme);
    //    List<XAxis> xAxis = ChartSeries.GetChartxAxis(dt);
    //    List<YAxis> yAxis = ChartSeries.GetChartyAxis(dt);
    //    // Declare the HighCharts object   
    //    DotNet.Highcharts.Highcharts BarChart = new DotNet.Highcharts.Highcharts(ChartName)
    //    .SetCredits(new Credits
    //    {
    //        Enabled = false
    //    })
    //    .SetExporting(new Exporting
    //    {
    //        Enabled = false
    //    })
    //       .SetOptions(new GlobalOptions
    //       {
    //           Lang = new DotNet.Highcharts.Helpers.Lang().SetAndUseCulture(""),
    //           Global = new Global { UseUTC = false }
    //       })
    //    .InitChart(new Chart
    //    {
    //        Events = new ChartEvents
    //        {
    //            Load = "function (){setInterval(UpdateChartBarSaleSupplierDetailsRial,300000);}"
    //        },
    //        DefaultSeriesType = ChartTypes.Column,
    //        Height = 300,
    //        ClassName = "ltrChart"
    //        //BorderWidth = 0,
    //        //                   BorderRadius = 15,
    //        //                   PlotBackgroundColor = null,
    //        //                   PlotShadow = false,
    //        //                   PlotBorderWidth = 0,
    //        //                   BackgroundColor = new BackColorOrGradient(new Gradient
    //        //                                                             {
    //        //                                                                 LinearGradient = new[] { 0, 0, 0, 400 },
    //        //                                                                 Stops = new object[,]
    //        //                                                                         {
    //        //                                                                             { 0, Color.FromArgb(255, 96, 96, 96) },
    //        //                                                                             { 1, Color.FromArgb(255, 16, 16, 16) }
    //        //                                                                         }
    //        //                                                             })
    //    })

    //        .SetTitle(new Title
    //        {
    //            Text = "",
    //            X = 0
    //        })
    //        //.SetSubtitle(new Subtitle
    //        //{
    //        //    Text = "تست تست تست تست",
    //        //    X = 0
    //        //})
    //        .SetYAxis(yAxis.ToArray())
    //        .SetXAxis(xAxis.ToArray())
    //        .SetSeries(seri.ToArray())
    //        .SetLegend(new Legend
    //        {

    //            Align = HorizontalAligns.Center,
    //            VerticalAlign = VerticalAligns.Bottom,
    //            Layout = Layouts.Horizontal,
    //            //LabelFormatter = "function() {return '---' + this.name ;}"

    //            //BorderWidth=1,
    //            //Width=380,
    //            //Floating=true,
    //            ////X=-35,
    //            //SymbolRadius=0,
    //            //SymbolWidth=10,
    //            //SymbolHeight=10,
    //            //Enabled=true,
    //            //ItemStyle = "textAlign: 'right'",
    //            //ItemMarginBottom=40


    //        })
    //        .SetTooltip(new Tooltip { 
    //           // Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }"
    //            HeaderFormat = " <span style=\"font-size:10px\">{point.key}</span><table> ",
    //            PointFormat = " <tr><td style=\"color:{series.color};padding:0\">{series.name}: </td><td style=\"padding:0\"><b>{point.y} </b></td></tr> ",
    //            FooterFormat = " </table>",
    //            Shared = true,
    //            UseHTML = true
    //        })
    //        ;
    //    return BarChart;
    //}
    //public static Highcharts GetChartBarSupplierDetailsWeight(DataTable dt, string CategoryTheme, string ChartName)
    //{

    //    List<Series> seri = ChartSeries.GetChartSeri(dt, CategoryTheme);
    //    List<XAxis> xAxis = ChartSeries.GetChartxAxis(dt);
    //    List<YAxis> yAxis = ChartSeries.GetChartyAxis(dt);
    //    // Declare the HighCharts object   
    //    DotNet.Highcharts.Highcharts BarChart = new DotNet.Highcharts.Highcharts(ChartName)
    //    .SetCredits(new Credits
    //    {
    //        Enabled = false
    //    })
    //    .SetExporting(new Exporting
    //    {
    //        Enabled = false
    //    })
    //        .SetOptions(new GlobalOptions
    //        {
    //            Lang = new DotNet.Highcharts.Helpers.Lang().SetAndUseCulture(""),
    //            Global = new Global { UseUTC = false }
    //        })
    //    .InitChart(new Chart
    //    {
    //        Events = new ChartEvents
    //        {
    //            Load = "function (){setInterval(UpdateChartBarSaleSupplierDetailsWeight,300000);}"
    //        },
    //        DefaultSeriesType = ChartTypes.Column,
    //        Height = 300,
    //        Width=null,
    //        SpacingBottom=15,
    //        SpacingTop=10,
    //        SpacingLeft=10,
    //        SpacingRight=10,
    //        ClassName = "ltrChart"

    //        //BorderWidth = 0,
    //        //                   BorderRadius = 15,
    //        //                   PlotBackgroundColor = null,
    //        //                   PlotShadow = false,
    //        //                   PlotBorderWidth = 0,
    //        //                   BackgroundColor = new BackColorOrGradient(new Gradient
    //        //                                                             {
    //        //                                                                 LinearGradient = new[] { 0, 0, 0, 400 },
    //        //                                                                 Stops = new object[,]
    //        //                                                                         {
    //        //                                                                             { 0, Color.FromArgb(255, 96, 96, 96) },
    //        //                                                                             { 1, Color.FromArgb(255, 16, 16, 16) }
    //        //                                                                         }
    //        //                                                             })
    //    })

    //        .SetTitle(new Title
    //        {
    //            Text = "",
    //            X = 0
    //        })
    //        //.SetSubtitle(new Subtitle
    //        //{
    //        //    Text = "تست تست تست تست",
    //        //    X = 0
    //        //})
    //        .SetYAxis(yAxis.ToArray())
    //        .SetXAxis(xAxis.ToArray())
    //        .SetSeries(seri.ToArray())
    //        .SetLegend(new Legend
    //        {

    //            Align = HorizontalAligns.Center,
    //            VerticalAlign = VerticalAligns.Bottom,
    //            Layout = Layouts.Horizontal,
    //            //LabelFormatter = "function() {return '---' + this.name ;}"

    //            //BorderWidth=1,
    //            //Width=380,
    //            //Floating=true,
    //            ////X=-35,
    //            //SymbolRadius=0,
    //            //SymbolWidth=10,
    //            //SymbolHeight=10,
    //            //Enabled=true,
    //            //ItemStyle = "textAlign: 'right'",
    //            //ItemMarginBottom=40


    //        })
    //        .SetTooltip(new Tooltip { 
    //           // Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }" 
    //            HeaderFormat = " <span style=\"font-size:10px\">{point.key}</span><table> ",
    //            PointFormat = " <tr><td style=\"color:{series.color};padding:0\">{series.name}: </td><td style=\"padding:0\"><b>{point.y} </b></td></tr> ",
    //            FooterFormat = " </table>",
    //            Shared = true,
    //            UseHTML = true
    //        })
    //        ;
    //    return BarChart;
    //}
    public static Highcharts GetChartBarSupplierDetailsDaily(DataTable dt, string CategoryTheme, string ChartName, string Updatename)
    {

        List<Series> seri = ChartSeries.GetChartSeri(dt, CategoryTheme);
        List<XAxis> xAxis = ChartSeries.GetChartxAxis(dt);
        List<YAxis> yAxis = ChartSeries.GetChartyAxis(dt);
        // Declare the HighCharts object   
        DotNet.Highcharts.Highcharts BarChart = new DotNet.Highcharts.Highcharts(ChartName)
        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetExporting(new Exporting
        {
            Enabled = false
        })
            .SetOptions(new GlobalOptions
            {
                Lang = new DotNet.Highcharts.Helpers.Lang().SetAndUseCulture(""),
                Global = new Global { UseUTC = false }
            })
        .InitChart(new Chart
        {
            Events = new ChartEvents
            {
                Load = "function (){setInterval(" + Updatename + ",300000);}"
            },
            DefaultSeriesType = ChartTypes.Column,
            Height = 300,
            Width = null,
            SpacingBottom = 15,
            SpacingTop = 10,
            SpacingLeft = 10,
            SpacingRight = 10,
            ClassName = "ltrChart"

            //BorderWidth = 0,
            //                   BorderRadius = 15,
            //                   PlotBackgroundColor = null,
            //                   PlotShadow = false,
            //                   PlotBorderWidth = 0,
            //                   BackgroundColor = new BackColorOrGradient(new Gradient
            //                                                             {
            //                                                                 LinearGradient = new[] { 0, 0, 0, 400 },
            //                                                                 Stops = new object[,]
            //                                                                         {
            //                                                                             { 0, Color.FromArgb(255, 96, 96, 96) },
            //                                                                             { 1, Color.FromArgb(255, 16, 16, 16) }
            //                                                                         }
            //                                                             })
        })

            .SetTitle(new Title
            {
                Text = "",
                X = 0
            })
            //.SetSubtitle(new Subtitle
            //{
            //    Text = "تست تست تست تست",
            //    X = 0
            //})
            .SetYAxis(yAxis.ToArray())
            .SetXAxis(xAxis.ToArray())
            .SetSeries(seri.ToArray())
            .SetLegend(new Legend
            {

                Align = HorizontalAligns.Center,
                VerticalAlign = VerticalAligns.Bottom,
                Layout = Layouts.Horizontal,
                //LabelFormatter = "function() {return '---' + this.name ;}"

                //BorderWidth=1,
                //Width=380,
                //Floating=true,
                ////X=-35,
                //SymbolRadius=0,
                //SymbolWidth=10,
                //SymbolHeight=10,
                //Enabled=true,
                //ItemStyle = "textAlign: 'right'",
                //ItemMarginBottom=40


            })
            .SetTooltip(new Tooltip
            {
                // Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }" 
                HeaderFormat = " <span style=\"font-size:10px\">{point.key}</span><table> ",
                PointFormat = " <tr><td style=\"color:{series.color};padding:0\">{series.name}: </td><td style=\"padding:0\"><b>{point.y} </b></td></tr> ",
                FooterFormat = " </table>",
                Shared = true,
                UseHTML = true
            })
            ;
        return BarChart;
    }
    public static Highcharts GetChartBarSupplierDetails(DataTable dt, string CategoryTheme, string ChartName,string Updatename)
    {
        List<Series> seri = ChartSeries.GetChartSeri(dt, CategoryTheme);
        List<XAxis> xAxis = ChartSeries.GetChartxAxisBarBig(dt);
        List<YAxis> yAxis = ChartSeries.GetChartyAxis(dt);
        // Declare the HighCharts object   
        DotNet.Highcharts.Highcharts BarChart = new DotNet.Highcharts.Highcharts(ChartName)
        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetExporting(new Exporting
        {
            Enabled = false
        })
        .SetOptions(new GlobalOptions
        {
            Lang = new DotNet.Highcharts.Helpers.Lang().SetAndUseCulture(""),
            Global = new Global { UseUTC = false }
        })
        .InitChart(new Chart
        {
            Events = new ChartEvents
                    {
                        Load = "function (){setInterval(" + Updatename + ",300000);}"
                    },
            DefaultSeriesType = ChartTypes.Column,
            Height = 600,
            //Width=1000
            ClassName = "ltrChart"
        })

            .SetTitle(new Title
            {
                Text = "",
                X = 0
            })
            //.SetSubtitle(new Subtitle
            //{
            //    Text = "تست تست تست تست",
            //    X = 0
            //})
            .SetYAxis(yAxis.ToArray())
            .SetXAxis(xAxis.ToArray())
            .SetSeries(seri.ToArray())
            .SetLegend(new Legend
            {

                Align = HorizontalAligns.Center,
                VerticalAlign = VerticalAligns.Bottom,
                Layout = Layouts.Horizontal,
                //LabelFormatter = "function() {return '---' + this.name ;}"

                //BorderWidth=1,
                //Width=380,
                //Floating=true,
                ////X=-35,
                //SymbolRadius=0,
                //SymbolWidth=10,
                //SymbolHeight=10,
                //Enabled=true,
                //ItemStyle = "textAlign: 'right'",
                //ItemMarginBottom=40


            })
            .SetTooltip(new Tooltip { 
                //Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }"
                HeaderFormat = " <span style=\"font-size:10px\">{point.key}</span><table> ",
                PointFormat = " <tr><td style=\"color:{series.color};padding:0\">{series.name}: </td><td style=\"padding:0\"><b>{point.y} </b></td></tr> ",
                FooterFormat = " </table>",
                Shared = true,
                UseHTML = true
            })
            ;
        return BarChart;
    }
    public static Highcharts GetChartBarSupplierBranchTarget(DataTable dt, string CategoryTheme, string ChartName)
    {
        List<Series> seri = ChartSeries.GetChartSeri(dt, CategoryTheme);
        List<XAxis> xAxis = ChartSeries.GetChartxAxisBarBigSaleSupplierBranchTarget(dt);
        List<YAxis> yAxis = ChartSeries.GetChartyAxis(dt);
        // Declare the HighCharts object   
        DotNet.Highcharts.Highcharts BarChart = new DotNet.Highcharts.Highcharts(ChartName)
        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetExporting(new Exporting
        {
            Enabled = false
        })
        .SetOptions(new GlobalOptions
        {
            Lang = new DotNet.Highcharts.Helpers.Lang().SetAndUseCulture(""),
            Global = new Global { UseUTC = false }
        })
        .InitChart(new Chart
        {
            DefaultSeriesType = ChartTypes.Column,
            //Events = new ChartEvents
            //{
            //    Load = "function (){setInterval(UpdateChartRial,360500);}"
            //},
            Height = 600,
            Width=1300,
            ClassName = "ltrChart"
        })
            .SetTitle(new Title
            {
                Text = "",
                X = 0
            })
            //.SetSubtitle(new Subtitle
            //{
            //    Text = "تست تست تست تست",
            //    X = 0
            //})
            .SetYAxis(yAxis.ToArray())
            .SetXAxis(xAxis.ToArray())
            .SetSeries(seri.ToArray())
            .SetLegend(new Legend
            {

                Align = HorizontalAligns.Center,
                VerticalAlign = VerticalAligns.Bottom,
                Layout = Layouts.Horizontal,
                //LabelFormatter = "function() {return '---' + this.name ;}"

                //BorderWidth=1,
                //Width=380,
                //Floating=true,
                ////X=-35,
                //SymbolRadius=0,
                //SymbolWidth=10,
                //SymbolHeight=10,
                //Enabled=true,
                //ItemStyle = "textAlign: 'right'",
                //ItemMarginBottom=40


            })
            .SetTooltip(new Tooltip
            {
                //Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }"
                HeaderFormat = " <span style=\"font-size:10px\">{point.key}</span><table> ",
                PointFormat = " <tr><td style=\"color:{series.color};padding:0\">{series.name}: </td><td style=\"padding:0\"><b>{point.y} </b></td></tr> ",
                FooterFormat = " </table>",
                Shared = true,
                UseHTML = true
            })
            ;
        return BarChart;
    }
    public static Highcharts GetChartBarPercentage(DataTable dt, string CategoryTheme, string ChartName)
    {

        List<Series> seri = ChartSeries.GetChartSeri(dt, CategoryTheme);
        List<XAxis> xAxis = ChartSeries.GetChartxAxis(dt);
        List<YAxis> yAxis = ChartSeries.GetChartyAxis(dt);
        // Declare the HighCharts object   
        DotNet.Highcharts.Highcharts BarChart = new DotNet.Highcharts.Highcharts(ChartName)
        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetExporting(new Exporting
        {
            Enabled = false
        })
           .SetOptions(new GlobalOptions
           {
               Lang = new DotNet.Highcharts.Helpers.Lang().SetAndUseCulture(""),
               Global = new Global { UseUTC = false }
           })
        .InitChart(new Chart
        {
            
            DefaultSeriesType = ChartTypes.Column,
            Height = 300,
            ClassName = "ltrChart"
            //BorderWidth = 0,
            //                   BorderRadius = 15,
            //                   PlotBackgroundColor = null,
            //                   PlotShadow = false,
            //                   PlotBorderWidth = 0,
            //                   BackgroundColor = new BackColorOrGradient(new Gradient
            //                                                             {
            //                                                                 LinearGradient = new[] { 0, 0, 0, 400 },
            //                                                                 Stops = new object[,]
            //                                                                         {
            //                                                                             { 0, Color.FromArgb(255, 96, 96, 96) },
            //                                                                             { 1, Color.FromArgb(255, 16, 16, 16) }
            //                                                                         }
            //                                                             })
        })        
            .SetTitle(new Title
            {
                Text = "",
                X = 0
            })
            //.SetSubtitle(new Subtitle
            //{
            //    Text = "تست تست تست تست",
            //    X = 0
            //})
            .SetYAxis(yAxis.ToArray())
            .SetXAxis(xAxis.ToArray())
            .SetSeries(seri.ToArray())
            .SetLegend(new Legend
            {

                Align = HorizontalAligns.Center,
                VerticalAlign = VerticalAligns.Bottom,
                Layout = Layouts.Horizontal,
                //LabelFormatter = "function() {return '---' + this.name ;}"

                //BorderWidth=1,
                //Width=380,
                //Floating=true,
                ////X=-35,
                //SymbolRadius=0,
                //SymbolWidth=10,
                //SymbolHeight=10,
                //Enabled=true,
                //ItemStyle = "textAlign: 'right'",
                //ItemMarginBottom=40


            })
            .SetTooltip(new Tooltip { 
                //Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }" 
                HeaderFormat = " <span style=\"font-size:10px\">{point.key}</span><table> ",
                PointFormat = " <tr><td style=\"color:{series.color};padding:0\">{series.name}: </td><td style=\"padding:0\"><b>{point.y} </b></td></tr> ",
                FooterFormat = " </table>",
                Shared = true,
                UseHTML = true
            })
            ;
        return BarChart;
    }



    public static Highcharts GetChartPie(DataTable dt, string CategoryTheme, string ChartName)
    {

        List<Series> seriPie = ChartSeries.GetChartSeriPie(dt, CategoryTheme);
        DotNet.Highcharts.Highcharts PieChart = new DotNet.Highcharts.Highcharts(ChartName)
        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetExporting(new Exporting
        {
            Enabled = false
        })
        .InitChart(new Chart
        {
            DefaultSeriesType = ChartTypes.Pie,
            Options3d = new ChartOptions3d
            {
                Enabled=true,
                Alpha=45,
                Beta=0
            },
            Width = 500,
            Height = 300,
            ClassName = "ltrChart"
        })

         .SetPlotOptions(new PlotOptions
         {
             Pie = new PlotOptionsPie
             {
                 ShowInLegend = true,
                 AllowPointSelect = true,
                 Depth=0,
                 DataLabels = new PlotOptionsPieDataLabels
                 {
                     Enabled = true,
                     Formatter = "function() { return this.point.name +' : '+  this.percentage.toFixed(2)+' %'; }"

                 }
             }
         })
         .SetTooltip(new Tooltip
         {
             Enabled = true,
             Formatter = @"function(){return this.point.name + ' : ' + ' % ' +this.percentage.toFixed(2); }"  //@"function(){return '<b>'+this.series.name +'</b> <br/>'+this.point.name + ' : ' +  this.percentage.toFixed(2)+' % '; }"
         })
                                  .SetLegend(new Legend
                                  {
                                      Align = HorizontalAligns.Center,
                                      VerticalAlign = VerticalAligns.Bottom,
                                      Layout = Layouts.Horizontal,
                                      BorderWidth = 0
                                  })

       .SetTitle(new Title { Text = "" }) //{ Text = chartTitleV + " بر اساس " + chartTitleH.TrimEnd(',').ToString() }
            //.SetXAxis(xAxisPie.ToArray())
            ////.SetXAxis(new XAxis { Title = new XAxisTitle { Text = "bbbb" } ,
            ////                      Categories = new xaxis
            ////})

       //.SetYAxis(new YAxis { Title = new YAxisTitle { Text = "bbbb" } })
       .SetLegend(new Legend
       {

           Align = HorizontalAligns.Center,
           VerticalAlign = VerticalAligns.Bottom,
           Layout = Layouts.Horizontal,
           //LabelFormatter = "function() {return '---' + this.name ;}"

           //BorderWidth=1,
           //Width=380,
           //Floating=true,
           ////X=-35,
           //SymbolRadius=0,
           //SymbolWidth=10,
           //SymbolHeight=10,
           //Enabled=true,
           //ItemStyle = "textAlign: 'right'",
           //ItemMarginBottom=40


       })
       .SetSeries(seriPie.ToArray());

        return PieChart;
    }

    public static Highcharts GetChartPolar(DataTable dt,DataTable descript, string CategoryTheme, string ChartName)
    {

        List<Series> seriPolar = ChartSeries.GetChartSeriPolar(dt,descript, CategoryTheme);

        List<string> yAxis = ChartSeries.GetChartyAxisPolarTargets();
        DotNet.Highcharts.Highcharts PolarChart = new DotNet.Highcharts.Highcharts(ChartName)
        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetExporting(new Exporting
        {
            Enabled = false
        })
        .InitChart(new Chart
        {
            Polar = true,
            Type = ChartTypes.Line,
            Width = 920,
            Height = 500,
            ClassName = "ltrChart"
        })

        .SetTitle(new Title { Text = "" })

        .SetSubtitle(new Subtitle { Text = "" })

        .SetPane(new Pane { Size = new PercentageOrPixel(80, true) })
            //.SetLabels(new Labels{ Style= new 

        //})
        .SetXAxis(new XAxis
        {
            Categories = yAxis.ToArray(),
            TickmarkPlacement = Placement.On,
            LineWidth = 0,
            Min = 0,

        })

        .SetYAxis(new YAxis
        {
            // Note the "poligon" interpolation for the grid
            //Labels = new YAxisLabels { Style = "Overflow : 'justify'", },
            GridLineInterpolation = "polygon",
            LineWidth = 0,
            Min = 0,
            //Labels = new YAxisLabels
            //{
            //    Style = "font-size: '11px'"
            //}
            //Labels = new YAxisLabels
            //{

            //    Align = HorizontalAligns.Left,
            //    X = 3,
            //    Y = 100,
            //    //Formatter = "function() { return Highcharts.numberFormat(this.value, 0); }",
            //},
        })

        //.SetTooltip(new Tooltip
            //{
            //    Shared = true,
            //})

        .SetLegend(new Legend
        {
            Align = HorizontalAligns.Right,
            VerticalAlign = VerticalAligns.Top,
            Y = 0,
            Layout = Layouts.Vertical,
            LabelFormatter = "function() {return this.name ;}"

        })
            //.SetTooltip(new Tooltip { Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }" })
            //.SetTooltip(new Tooltip
            //{
            //    //Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }" 
            //    HeaderFormat = " <span style=\"font-size:10px\">{point.key}</span><table> ",
            //    PointFormat = " <tr><td style=\"color:{series.color};padding:0\">{series.name}: </td><td style=\"padding:0\"><b>{point.y} {point.dataLabels} </b></td></tr> ",
            //    FooterFormat = " </table>",
            //    Shared = true,
            //    UseHTML = true
            //})
        .SetTooltip(new Tooltip
        {
            //Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }" 
            HeaderFormat = "<dir style=\"direction: rtl\"> <span style=\"font-weight: bold;font-size:15px\">{point.x}</span><table style=\"direction: rtl\"> ",
            PointFormat = " <tr><td style=\"color:{point.color};padding:0\">{series.name}: </td><td style=\"padding:0\"><b>{point.y} {point.dataLabels} </b></td></tr> ",
            FooterFormat = " </table></div>",
            Shared = true,
            UseHTML = true,            

        })
        .SetSeries(seriPolar.ToArray())
            //.SetSeries(new[]
            // {
            //     new Series
            //     {
            //         Name = "Po1",
            //         Data = new Data(seriPolar.ToArray()),
            //         PlotOptionsLine = new PlotOptionsLine
            //         { 
            //             PointPlacement = new PointPlacement(Placement.On)

       //         }
            //     }
            // })
        ;

        return PolarChart;
    }


    public static Highcharts GetOneLineChart(DataTable dt, string CategoryTheme)
    {
        List<Series> seri = ChartSeries.GetChartSeri(dt, CategoryTheme);
        List<XAxis> xAxis = ChartSeries.GetChartxAxis(dt);
        // Declare the HighCharts object   
        DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart")
        .SetCredits(new Credits
        {
            Enabled = false
        })
        .SetExporting(new Exporting
        {
            Enabled = false
        })
        .InitChart(new Chart { DefaultSeriesType = ChartTypes.Line, ClassName = "ltrChart" })
            .SetTitle(new Title
            {
                Text = "",
                X = 0
            })
            //.SetSubtitle(new Subtitle
            //{
            //    Text = "تست تست تست تست",
            //    X = 0
            //})
            .SetXAxis(xAxis.ToArray())
            .SetSeries(seri.ToArray())
            .SetLegend(new Legend
            {

                Align = HorizontalAligns.Center,
                VerticalAlign = VerticalAligns.Bottom,
                Layout = Layouts.Horizontal,
                //LabelFormatter = "function() {return '---' + this.name ;}"

                //BorderWidth=1,
                //Width=380,
                //Floating=true,
                ////X=-35,
                //SymbolRadius=0,
                //SymbolWidth=10,
                //SymbolHeight=10,
                //Enabled=true,
                //ItemStyle = "textAlign: 'right'",
                //ItemMarginBottom=40


            })
            .SetTooltip(new Tooltip { Formatter = "function() { return '<b>'+ this.series.name +'</b><br />Y: '+ this.y + '<br />X: '+ this.x; }" })
            ;
        return chart;
    }
}