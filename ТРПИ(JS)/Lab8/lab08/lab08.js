$(document).ready(function(){
    $(".dws-form").on("click",".tab",function(){
        $(".dws-form ").find(".active").removeClass("active");
        $(this).addClass("active");
        //выборка элемента по индексу 
        $(".tab-form").eq($(this).index()).addClass("active");
    })
});
