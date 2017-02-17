import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'assemblysummary',
    template: require('./assemblysummary.component.html')
})
export class AssemblySummaryComponent {
   public summaries: AssemblySummary[];

    constructor(http: Http) {
       http.get('/api/AssemblyTestSummary/').subscribe(result => {
           this.summaries = result.json();
        });
    }
}

interface AssemblySummary {
    assemblyName: string;
    passed: number;
    failed: number;

}
