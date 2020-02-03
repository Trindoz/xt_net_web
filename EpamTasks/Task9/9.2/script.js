function result(){
    pattern=/^[\+\-]?(?:(?:(?:\d+\.)?\d+)?(?:\^|root|\*|\/|\+|\-)?)+$/g
    if(!document.getElementById('textarea').value.match(pattern))
    {alert('Check input!')}
else{alert(calculate(document.getElementById("textarea").value))}
};
function calculate(s)
{
var arr = s.split('');
var mode=count(arr)
for(var i=0;i<arr.length;i++)
    {
        for(var j=0; j<mode.length;j++)
            {
                if(i==mode[j])
                    {
                    arr.splice(i+j*2,0,')');
                    arr.unshift('(');
                    }
            }
    }
arr=arr.join('');
var result=convert(arr);
return result;
};
function count(s) 
{   var res =[];
    for(var i=0;i<s.length;i++)
        {
            if(s[i]=='*'||s[i]=='/'){
                res.push(i);
                } 
        };return res;
};
function convert(s){
    return (new Function('return '+s))();
}
