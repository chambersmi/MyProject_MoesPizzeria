import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GrindersComponent } from './grinders.component';

describe('GrindersComponent', () => {
  let component: GrindersComponent;
  let fixture: ComponentFixture<GrindersComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GrindersComponent]
    });
    fixture = TestBed.createComponent(GrindersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
