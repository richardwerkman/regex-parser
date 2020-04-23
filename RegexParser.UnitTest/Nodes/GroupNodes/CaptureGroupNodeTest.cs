﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexParser.Nodes;
using RegexParser.Nodes.GroupNodes;
using System.Collections.Generic;

namespace RegexParser.UnitTest.Nodes.GroupNodes
{
    [TestClass]
    public class CaptureGroupNodeTest
    {
        [TestMethod]
        public void ToStringOnEmptyNodeShouldReturnEmptyCaptureGroup()
        {

            // Arrange
            var target = new CaptureGroupNode();

            // Act
            var result = target.ToString();

            // Assert
            Assert.AreEqual("()", result);
        }

        [TestMethod]
        public void ToStringOnCaptureGroupNodeWithChildNodeCaptureGroupWithChildNode()
        {
            // Arrange
            var childNode = new CharacterNode('a');
            var target = new CaptureGroupNode(childNode);

            // Act
            var result = target.ToString();

            // Assert
            Assert.AreEqual("(a)", result);
        }

        [TestMethod]
        public void ToStringOnCaptureGroupNodeMulitpleWithChildNodesCaptureGroupWithChildNodes()
        {
            // Arrange
            var childNodes = new List<RegexNode> { new CharacterNode('a'), new CharacterNode('b'), new CharacterNode('c') };
            var target = new CaptureGroupNode(childNodes);

            // Act
            var result = target.ToString();

            // Assert
            Assert.AreEqual("(abc)", result);
        }
    }
}
