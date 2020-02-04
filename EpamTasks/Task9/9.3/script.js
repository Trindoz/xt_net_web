function move(takefrom, puton,check) {
	var take = document.getElementById(takefrom);
    var put = document.getElementById(puton);
  var selected=false;
    
	for(var item = 0; item < take.options.length; item++) {   
        
        if(take.options[item].selected == check) {
            
				var option = take.options[item];
                var createoption = document.createElement("option");
				createoption.value = option.value;
				createoption.text = option.text;
                createoption.selected = false;
				put.add(createoption);
				take.remove(item);
                item--;
                selected=true;
        } 
} 
    if(!selected) {
       alert('You have nothing to replace!')}
    if(document.getElementById('availiable').length==0){
    document.getElementById('button1').disabled=true;
}
    if(document.getElementById('availiable').length>0){
        document.getElementById('button1').disabled=false;    
    }
    if(document.getElementById('selected').length==0){
        document.getElementById('button4').disabled=true;
    }
    if(document.getElementById('selected').length>0){
        document.getElementById('button4').disabled=false; 
    }
   
}

