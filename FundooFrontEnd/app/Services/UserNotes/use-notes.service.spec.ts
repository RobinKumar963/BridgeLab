import { TestBed } from '@angular/core/testing';

import { UseNotesService } from './use-notes.service';

describe('UseNotesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: UseNotesService = TestBed.get(UseNotesService);
    expect(service).toBeTruthy();
  });
});
