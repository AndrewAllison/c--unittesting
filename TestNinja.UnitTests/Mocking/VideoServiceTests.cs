using NUnit.Framework;
using TestNinja.Mocking;
using Moq;
using System.Collections.Generic;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        private VideoService _videoService;
        private Mock<IFileReader> _fileReader;
        private Mock<IVideoRepository> _repository;

        [SetUp]
        public void Setup()
        {
            _fileReader = new Mock<IFileReader>();
            _repository = new Mock<IVideoRepository>();

            _videoService = new VideoService(_fileReader.Object, _repository.Object);
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");

            var result = _videoService.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
            _fileReader.Verify(fr => fr.Read("video.txt"));
        }

        [Test]
        public void GetUnnprocessedVideos_AllVIdeosAreProcessed_ReturnEmptyString()
        {
            _repository.Setup(r => r.GetUnnprocessedVideos()).Returns(new List<Video>());

            var resut = _videoService.GetUnprocessedVideosAsCsv();

            Assert.That(resut, Is.EqualTo(""));
        }

        [Test]
        public void GetUnnprocessedVideos_When_UnprocessedVideos_ReturnIds()
        {
            var videoList = new List<Video> {
                new Video { Id = 1, IsProcessed = false },
                new Video { Id = 2, IsProcessed = false },
                new Video { Id = 5, IsProcessed = false },
            };
            _repository.Setup(r => r.GetUnnprocessedVideos()).Returns(videoList);

            var resut = _videoService.GetUnprocessedVideosAsCsv();

            Assert.That(resut, Is.EqualTo("1,2,5"));
        }
    }
}
