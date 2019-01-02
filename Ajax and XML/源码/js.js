var xmlHttp= createXmlHttpRequestObject();

function createXmlHttpRequestObject(){
	var xmlHttp;	//local var
	
	if(window.XMLHttpRequest){ //浏览器请求XmlHttp成功
		xmlHttp=new XMLHttpRequest();//for common browser
	}
	else{
		xmlHttp=new ActiveXObject("Microsoft.XMLHTTP"); //for uncommon browser
	}
	
	return xmlHttp;//the Core of ajax,communicate between the browser and the server
}

function process(){
	if(xmlHttp){
		try{
			xmlHttp.open("GET","http://localhost/xue.txt",true);//configure connection(not open)
			xml.openreadystatechange=handleServerResponse;//run handleServerResponse Function every time change xmlHttp status
			xmlHttp.send(null);//send request to server
		}catch(e){
			alert(e.toString());
		}
	}
}

function handleServerResponse(){
	theD =document.getElementById('theD');
	if(xmlHttp.readyState==1){//established connection with server
		theD.innerHTML+="Status 1: server connection established <br/>";
	}else if(xmlHttp.readyState==2){
		theD.innerHTML+="Status 2: request received <br/>";
	}else if(xmlHttp.readyState==3){
		theD.innerHTML+="Status 3: processing request <br/>";
	}else if(xmlHttp.readyState==4){
		if(xmlHttp.status=200){
			try{
				text=xmlHttp.responseText;
				theD.innerHTML+="Status 4: request is finished <br/>";
				theD.innerHTML+=text;
			}catch(e)
			{
				alert(e.toString());
			}
		}else{
			alert(xmlHttp.statusText);
		}
	}
}



