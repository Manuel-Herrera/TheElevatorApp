namespace TheElevatorApp.Test
{
    public class ElevatorClassTest
    {
        [TestFixture]
        public class ElevatorTests
        {
            [Test]
            public void MoveTo1or5_UpdatesCurrentFloor()
            {
                var elevator = new Elevator();
                int calledFrom = 5;

                elevator.MoveTo1or5(calledFrom);

                Assert.AreEqual(calledFrom, elevator.CurrentFloor);
            }

            [Test]
            public void UpAndDown_UpdatesCurrentFloor()
            {
                var elevator = new Elevator();
                int targetFloor = 3;
                int expectedFloor = 3;

                elevator.UpAndDown(targetFloor);

                Assert.AreEqual(expectedFloor, elevator.CurrentFloor);
            }

            [Test]
            public void UpAndDown_UpdatesCurrentDirection()
            {
                var elevator = new Elevator();
                int targetFloor = 3;
                Direction expectedDirection = Direction.Up;

                elevator.UpAndDown(targetFloor);

                Assert.AreEqual(expectedDirection, elevator.CurrentDirection);
            }
        }
    }
}