$('#OptionalWeight .btn').click(function () {
    $("#OptionalWeight > .btn").removeClass("active");
    $(this).addClass("active");
    $.ajax({
        url: '/AjaxUpdaterSaleCoOptionalWeight.aspx',
        data: { type: $(this).val() }
    }).success(function (data) {
        var chrt = ChartBarCoOptionalWeight;
        chrt.series[0].update({ data: data[0].Data.ArrayData, color: 'rgb(' + data[0].Color + ')' }, true);
        chrt.series[1].update({ data: data[1].Data.ArrayData, color: 'rgb(' + data[1].Color + ')' }, true);
        chrt.redraw();
    });
});