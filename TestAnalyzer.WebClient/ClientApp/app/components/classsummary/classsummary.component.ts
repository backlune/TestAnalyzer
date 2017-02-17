import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'classsummary',
    template: require('./classsummary.component.html')
})
export class ClassSummaryComponent {
    public forecasts: WeatherForecast[];

    constructor(http: Http) {
        http.get('/api/SampleData/WeatherForecasts').subscribe(result => {
            this.forecasts = result.json();
        });
    }
}

interface WeatherForecast {
    dateFormatted: string;
    temperatureC: number;
    temperatureF: number;
    summary: string;
}
