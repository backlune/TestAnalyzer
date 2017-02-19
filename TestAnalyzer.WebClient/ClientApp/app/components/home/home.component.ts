import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'home',
    template: require('./home.component.html')
})
export class HomeComponent {
    public summary: TestRunSummary;

    getPercentString(percent: number) {
        var p = (percent * 100) + "%";
        console.log(p)
        return p;
    };

   constructor(http: Http) {
       http.get('/api/TestSummary/').subscribe(result => {
           this.summary = result.json();
           console.log(this.summary);
      });
   }
}

interface TestRunSummary {
   percentagePassed: number;
   totalPassed: number;
   totalFailed: number;
   totalDuration: string;
   totalTests: number;
   slowestTest: TestWithDuration[];
}

interface TestWithDuration {
   name: string;
   duration: string;
}
