import { TestBed } from '@angular/core/testing';

import { LinkPreviewService } from './link-preview.service';

describe('LinkPreviewService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: LinkPreviewService = TestBed.get(LinkPreviewService);
    expect(service).toBeTruthy();
  });
});
