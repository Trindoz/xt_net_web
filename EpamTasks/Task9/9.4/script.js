function createMyElements(){
$('body').append('<div class="myclass"></div>');
$('.myclass').append('<button id="back">BACK</button>');
$('.myclass').append('<button id="stop">STOP</button>');}
var url='https://qna.habr.com/q/599166'
location.assign(url);
createMyElements();