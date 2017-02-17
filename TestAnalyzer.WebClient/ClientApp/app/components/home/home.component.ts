import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'home',
    template: require('./home.component.html')
})
export class HomeComponent {
   public summary: AssemblySummary;

   constructor(http: Http) {
      http.get('/api/TestSummary/').subscribe(result => {
         this.summary = result.json();
      });
   }

}

interface AssemblySummary {
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
