import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Movie } from '../models/movie'
import { MovieService } from '../Services/movie.service';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.scss']
})
export class MovieComponent implements OnInit {

moviesList: Array<Movie>;

@Input()
public movies: Movie[] ;
public currentMovie: Movie;
searchModel: string;

@Output() public select: EventEmitter<{}> = new EventEmitter();

  constructor(private movieService: MovieService) { }

  ngOnInit(): void {
    this.movieService.getAllMovies().subscribe(data => {
      this.moviesList = data.movies;
      console.log(data);
      console.log(this.moviesList);
    })
  }

  public onSelect(movie: Movie): void {
    this.currentMovie = movie; 
    this.select.emit(movie);
  }

}
