import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';
import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { ClassSummaryComponent } from './components/classsummary/classsummary.component';
import { AssemblySummaryComponent } from './components/assemblysummary/assemblysummary.component'

@NgModule({
   bootstrap: [AppComponent],
   declarations: [
      AppComponent,
      NavMenuComponent,
      ClassSummaryComponent,
      AssemblySummaryComponent,
      HomeComponent
   ],
   imports: [
      UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
      RouterModule.forRoot([
         { path: '', redirectTo: 'home', pathMatch: 'full' },
         { path: 'home', component: HomeComponent },
         { path: 'assemblysummary', component: AssemblySummaryComponent },
         { path: 'fetch-data', component: ClassSummaryComponent },
         { path: '**', redirectTo: 'home' }
      ])
   ]
})
export class AppModule {
}
