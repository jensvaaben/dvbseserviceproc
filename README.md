# dvbseserviceproc
DVBStreamExplorer Service File Processor

This application takes a XML file of DVB SI information produced by [DVBStreamExplorer](http://www.dvbstreamexplorer.com/dvbse/dvbse.php) as input. It will then upload the data as JSON to an URL of choice.
While the application can be used as is, it is mostly intended as a starting point for developers who need some custom handling of information produced by DVBStreamExplorer.
You'll find a small example of of service written in PHP that will consume the output produced by this application here [https://gist.github.com/jensvaaben/633077869a27c3193343](https://gist.github.com/jensvaaben/633077869a27c3193343). This sample really doesn't do anything useful. It's merely meant as starting point for your own application. Real production application could do stuff like saving data in a database.
You can also use this client app to send data to following live test service: http://dvbseserviceapi.appspot.com
