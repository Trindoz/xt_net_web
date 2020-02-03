var input=document.querySelector('.block').innerHTML;
var chars=[' ','    ','?','!',':',',','.'];
var words=[];
var letters=[];
var array=input.split('');
//getting an array of words without separators    
for(var i=0; i<chars.length;i++)
    {
        if(input.includes(chars[i]))
        {words=input.split(chars[i])}
    };
//getting an array of letters to delete from string
for(var i=0;i<words.length;i++)
    {
        var str=String(words[i]);
        for(var j=0;j<str.length;j++)
            {
                if(str.split(str[j]).length-1>1)
                {
                    if(!letters.includes(str[j]))
                    {letters.push(str[j]);}
                }
            }
    };
for(var i=0; i<array.length;i++)
    {
        for(var j=0;j<letters.length;j++)
            {
                if(array[i]==letters[j])
                {
                    array.splice(i,1)
                }
            }
    }
var result= array.join('')
alert(result);

