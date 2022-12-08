var dict={
	"first Name" : "Shivadatt",
	"Last Name" : "Dubey",
	"Qualification" : [{"10th":{"Board": "UP","Collage Name": "S.G.I.Collage","Branch": "Art","Year of Passing": 2016}},
						{"12th":{"Board": "UP","Collage Name": "S.G.I.Collage","Branch": "PCM","Year of Passing": 2018}},
						{"UG":{"Board": "AKTU","Collage Name": "ITM Gorakhpur","Branch": "CSE","Year of Passing": 2022}},
						{"PG":{"Board": "NA","Collage Name": "N/A","Branch": "NO","Year of Passing": 0}}]
	};

var dictstring = JSON.stringify(dict);
const fs = require(fs);
fs.writeFile("thing.json", dictstring, function(err, result) {
    if(err) console.log('error', err);
});
