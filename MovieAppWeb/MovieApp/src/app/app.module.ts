import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MovieComponent } from './movie/movie.component';
import { MovieFilterPipePipe } from './movie-filter-pipe.pipe';
import { AppSearchComponent } from './app-search/app-search.component';

@NgModule({
  declarations: [
    AppComponent,
    MovieComponent,
    MovieFilterPipePipe,
    AppSearchComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
