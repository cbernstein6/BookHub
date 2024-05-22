import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-book-page',
  standalone: true,
  imports: [],
  templateUrl: './book-page.component.html',
  styleUrl: './book-page.component.css'
})
export class BookPageComponent {
  title?: string | null;
  description?: string | null;
  author?: string | null;
  genre?: string | null;
  img?: string | null;

  constructor(private route : ActivatedRoute){}

  ngOnInit(): void {
    this.route.queryParamMap.subscribe(params => {
      this.title = params.get('title');
      this.description = params.get('description');
      this.author = params.get('author');
      this.genre = params.get('genre');
      this.img = params.get('img');
    });
  }
}
