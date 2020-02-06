var urls=['https://ru.wikipedia.org/wiki/Microsoft','https://www.google.ru/','https://www.microsoft.com/ru-ru','https://github.com/']

function startTimer(url) {
    var timer = document.getElementById("timer");
    var s = timer.innerHTML;
    s--;
    if (s == 15) {
        document.getElementById("content").src='https://ru.wikipedia.org/';
    }
    if(s==10){
        document.getElementById("content").src='https://ru.wikipedia.org/wiki/Microsoft'
    }
    if(s==5){
        document.getElementById("content").src='https://ru.wikipedia.org/wiki/Apple'
    }
    if(s==0){
        s=20;
    }
    document.getElementById("timer").innerHTML=s;
    setTimeout(startTimer, 1000);
  }
 
  