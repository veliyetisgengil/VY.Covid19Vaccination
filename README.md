# Covid19Vaccination
Turkey Covid 19 Vaccination

### Run the command in the parent directory (same path .sln)

```docker build -f src/VY.Covid19Vaccination.Presentation/Dockerfile -t the_covid19 .```

### Container Restart

```docker run -d -p 5000:80 --name the_covid19_container the_covid19```

### Test the web api with http.
http://localhost:5000/Covid/GetCovidDataAll

http://localhost:5000/Covid/GetCovidDataByCity?city=Kayseri

### Stop the container
```docker stop the_covid19_container```

### Web api use on docker hub
```docker pull veliyetisgengil/the_covid19```

Data Kaynağı : https://www.kaggle.com/omercolakoglu/turkey-covid-19-vaccination-data
